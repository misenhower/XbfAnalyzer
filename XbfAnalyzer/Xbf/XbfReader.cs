using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace XbfAnalyzer.Xbf
{
    public class XbfReader
    {
        public XbfReader(string path)
        {
            using (var fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new BinaryReaderEx(fileStream, Encoding.Unicode))
            {
                Header = new XbfHeader(reader);
                ReadStringTable(reader);
                AssemblyTable = ReadTable(reader, r => new XbfAssembly(this, r));
                TypeNamespaceTable = ReadTable(reader, r => new XbfTypeNamespace(this, r));
                TypeTable = ReadTable(reader, r => new XbfType(this, r));
                PropertyTable = ReadTable(reader, r => new XbfProperty(this, r));
                XmlNamespaceTable = ReadTable(reader, r => StringTable[r.ReadInt32()]);

                if (Header.MajorFileVersion >= 2)
                    ReadNodesV2(reader);
            }
        }

        public XbfHeader Header { get; private set; }
        public string[] StringTable { get; private set; }
        public XbfAssembly[] AssemblyTable { get; private set; }
        public XbfTypeNamespace[] TypeNamespaceTable { get; private set; }
        public XbfType[] TypeTable { get; private set; }
        public XbfProperty[] PropertyTable { get; private set; }
        public string[] XmlNamespaceTable { get; private set; }

        public string NodeResultString { get; private set; }
        public string NodeParserError { get; private set; }

        private string ReadString(BinaryReader reader)
        {
            return new string(reader.ReadChars(reader.ReadInt32()));
        }

        private void ReadStringTable(BinaryReader reader)
        {
            int stringCount = reader.ReadInt32();
            string[] stringTable = new string[stringCount];

            bool isXbfV2 = Header.MajorFileVersion >= 2;

            for (int i = 0; i < stringCount; i++)
            {
                stringTable[i] = ReadString(reader);

                // XBF v2 files appear to have two extra bytes after each string.
                // TODO: Determine if these bytes have any purpose.
                if (isXbfV2)
                    reader.ReadBytes(2);
            }

            StringTable = stringTable;
        }

        private T[] ReadTable<T>(BinaryReader reader, Func<BinaryReader, T> objectGenerator)
        {
            int count = reader.ReadInt32();
            T[] result = new T[count];

            for (int i = 0; i < count; i++)
                result[i] = objectGenerator(reader);

            return result;
        }


        private int _firstNodeSectionPosition;
        private List<Tuple<int, int>> _nodeSectionOffsets;

        // XBF v2 node parser functionality is mostly based on analysis of XBF v2.1 files. There are probably a lot of mistakes here!
        private void ReadNodesV2(BinaryReaderEx reader)
        {
            // The first value is an int that indicates how many node sections we have.
            // Each node section comes in two parts: the nodes themselves come first, followed by line/column data (positional data
            // which indicates where the objects were located in the source XAML file).
            // For each node section, there will be two offset numbers: one for the nodes, and one for the positional data.
            //
            // So far I've only seen secondary node sections being used for visual state data (VisualStateGroups, VisualStates, etc.).
            // Some visual state information is included in the primary node stream (after control character 0x0F) but fully-expanded
            // objects are only available in the secondary node streams (one per object that has VisualStateGroups defined).

            // Get the number of node sections
            int nodeSectionCount = reader.ReadInt32();

            // Get the offsets for each node section
            _nodeSectionOffsets = new List<Tuple<int, int>>(nodeSectionCount);
            int nodeOffset, posOffset;
            for (int i = 0; i < nodeSectionCount; i++)
            {
                nodeOffset = reader.ReadInt32();
                posOffset = reader.ReadInt32();
                _nodeSectionOffsets.Add(new Tuple<int, int>(nodeOffset, posOffset));
            }

            // We are now at the position in the stream of the first actual node data. We'll need this position later.
            _firstNodeSectionPosition = (int)reader.BaseStream.Position;

            // The first node section contains the primary XAML data (and the root XAML object)
            XbfObject rootObject = new XbfObject();
            int endPosition = _firstNodeSectionPosition + _nodeSectionOffsets[0].Item2;

            try
            {
                // Read the node bytes
                byte controlByte;
                while (reader.BaseStream.Position < endPosition)
                {
                    controlByte = reader.ReadByte();
                    switch (controlByte)
                    {
                        case 0x12: // This usually appears to be the first byte encountered. I'm not sure what the difference between 0x12 and 0x03 is.
                        case 0x03: // Root node namespace declaration
                            {
                                string namespaceName = XmlNamespaceTable[reader.ReadUInt16()];
                                string prefix = ReadString(reader);
                                if (!string.IsNullOrEmpty(prefix))
                                    prefix = "xmlns:" + prefix;
                                else
                                    prefix = "xmlns";
                                rootObject.Properties.Add(new XbfObjectProperty(prefix, namespaceName));
                            }
                            break;

                        case 0x0B: // Indicates the class of the root object (i.e., x:Class)
                            {
                                rootObject.Properties.Add(new XbfObjectProperty("x:Class", ReadString(reader)));
                            }
                            break;

                        case 0x17: // Root object begin
                            {
                                rootObject.TypeName = GetTypeNameV2(reader.ReadUInt16());
                                ReadObjectV2(reader, endPosition, rootObject);
                            }
                            break;

                        default:
                            throw new Exception(string.Format("Unrecognized character 0x{0:X2} in node stream", controlByte));
                    }
                }
            }
            catch (Exception e)
            {
                NodeParserError = string.Format("Error parsing node stream at file position {0} (0x{0:X}) (node start position was: {1} (0x{1:X}))" + Environment.NewLine, reader.BaseStream.Position - 1, _firstNodeSectionPosition) + e.ToString();
            }

            if (rootObject != null)
                NodeResultString = rootObject.ToString();
        }

        private XbfObject ReadObjectV2(BinaryReaderEx reader, int endPosition, XbfObject obj = null)
        {
            if (obj == null)
            {
                obj = new XbfObject();
                obj.TypeName = GetTypeNameV2(reader.ReadUInt16());
            }

            byte controlByte;
            while (reader.BaseStream.Position < endPosition)
            {
                controlByte = reader.ReadByte();
                switch (controlByte)
                {
                    case 0x0C: // Connection
                        // This byte (0x0C) indicates the current object needs to be connected to something in the generated Connect method.
                        // This can include event handlers, named objects (to be accessed via instance variables), etc.
                        // Event handlers aren't explicitly included as part of the XBF node stream since they're wired up in (generated) code.
                        // Each object that needs to be connected to something has a unique ID indicated in this section.
                        // Example bytes: 0C 04 01 00 00 00

                        // I've only seen 0x04 as the first byte value -- this may be a byte count?
                        reader.ReadByte();
                        // Connection ID
                        obj.ConnectionID = reader.ReadInt32();
                        break;

                    case 0x0D: // x:Name
                        if (obj.Name != null)
                            throw new Exception("Object already has a Name value");
                        obj.Name = GetPropertyValueV2(reader).ToString();
                        break;

                    case 0x0E: // x:Uid
                        if (obj.Uid != null)
                            throw new Exception("Object already as a Uid value");
                        obj.Uid = GetPropertyValueV2(reader).ToString();
                        break;

                    case 0x1A: // Property begin
                    case 0x1B: // Property begin (not sure what the difference from 0x1A is)
                        {
                            string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                            object propertyValue = GetPropertyValueV2(reader);
                            obj.Properties.Add(new XbfObjectProperty(propertyName, propertyValue));
                        }
                        break;

                    case 0x1E: // StaticResource
                        {
                            string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                            object propertyValue = GetPropertyValueV2(reader);
                            propertyValue = string.Format("{{StaticResource {0}}}", propertyValue);
                            obj.Properties.Add(new XbfObjectProperty(propertyName, propertyValue));
                        }
                        break;

                    case 0x24: // ThemeResource
                        {
                            string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                            object propertyValue = GetPropertyValueV2(reader);
                            propertyValue = string.Format("{{ThemeResource {0}}}", propertyValue);
                            obj.Properties.Add(new XbfObjectProperty(propertyName, propertyValue));
                        }
                        break;

                    case 0x13: // Object collection begin
                        {
                            string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                            var objects = ReadObjectCollectionV2(reader, endPosition);
                            obj.Properties.Add(new XbfObjectProperty(propertyName, objects));
                        }
                        break;

                    case 0x14: // Object begin
                        {
                            // We are starting a new object inside of the current object. It will be applied as a property of the current object.
                            var subObj = ReadObjectV2(reader, endPosition);

                            // Determine what we need to do with the new object
                            controlByte = reader.ReadByte();
                            switch (controlByte)
                            {
                                case 0x07: // Add the new object as a property of the current object
                                case 0x20: // Same as 0x07, but this seems to occur when the object is a {Binding} value
                                    string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                                    obj.Properties.Add(new XbfObjectProperty(propertyName, subObj));
                                    break;

                                default:
                                    throw new Exception(string.Format("Unrecognized character 0x{0:X2} while parsing child object", controlByte));
                            }
                        }
                        break;

                    case 0x21: // Object end
                        return obj;

                    default:
                        throw new Exception(string.Format("Unrecognized character 0x{0:X2} while parsing object", controlByte));
                }
            }

            throw new Exception("Reached end of stream before finishing object");
        }

        private List<XbfObject> ReadObjectCollectionV2(BinaryReaderEx reader, int endPosition)
        {
            List<XbfObject> result = new List<XbfObject>();

            byte controlByte;
            while (reader.BaseStream.Position < endPosition)
            {
                controlByte = reader.ReadByte();
                switch (controlByte)
                {
                    case 0x14: // Object begin
                        result.Add(ReadObjectV2(reader, endPosition));
                        break;

                    case 0x0F: // VisualStateGroups
                        {
                            // The first value is the index of the node section that contains the fully-expanded nodes for this VisualStateGroup collection.
                            int nodeSection = reader.Read7BitEncodedInt();

                            reader.ReadBytes(3); // TODO

                            // Number of visual states
                            int visualStateCount = reader.Read7BitEncodedInt();
                            // The following bytes indicate which visual states belong in each group
                            int[] visualStateGroupMemberships = new int[visualStateCount];
                            for (int i = 0; i < visualStateCount; i++)
                                visualStateGroupMemberships[i] = reader.Read7BitEncodedInt();

                            // Number of visual states (again?)
                            int visualStateCount2 = reader.Read7BitEncodedInt();
                            if (visualStateCount != visualStateCount2)
                                throw new Exception("Visual state counts did not match"); // TODO: What does it mean when this happens? Will it ever happen?

                            // Get the VisualState objects
                            var visualStates = new XbfObject[visualStateCount2];
                            for (int i = 0; i < visualStateCount2; i++)
                            {
                                int nameID = reader.ReadUInt16();
                                reader.ReadBytes(7); // TODO

                                var vs = new XbfObject();
                                vs.TypeName = "VisualState";
                                vs.Name = StringTable[nameID];

                                visualStates[i] = vs;
                            }

                            // Number of VisualStateGroups
                            int visualStateGroupCount = reader.Read7BitEncodedInt();

                            // Get the VisualStateGroup objects
                            var visualStateGroups = new XbfObject[visualStateGroupCount];
                            for (int i = 0; i < visualStateGroupCount; i++)
                            {
                                int nameID = reader.ReadUInt16();
                                reader.ReadByte(); // TODO

                                // The offset within the node section for this VisualStateGroup
                                int objectOffset = reader.Read7BitEncodedInt();

                                var vsg = new XbfObject();
                                vsg.TypeName = "VisualStateGroup";
                                vsg.Name = StringTable[nameID];

                                // Get the visual states that belong to this group
                                var states = new List<XbfObject>();
                                for (int j = 0; j < visualStateGroupMemberships.Length; j++)
                                {
                                    if (visualStateGroupMemberships[j] == i)
                                        states.Add(visualStates[j]);
                                }
                                if (states.Count > 0)
                                    vsg.Properties.Add(new XbfObjectProperty("States", states));

                                visualStateGroups[i] = vsg;
                            }

                            reader.ReadBytes(5); // TODO

                            // At the end we have a list of string references
                            int stringCount = reader.Read7BitEncodedInt();
                            for (int i = 0; i < stringCount; i++)
                            {
                                int nameID = reader.ReadUInt16(); // TODO
                                System.Diagnostics.Debug.Print("Found string \"{0}\"", StringTable[nameID]);
                            }

                            // Now add all the VisualStateGroups to the collection
                            for (int i = 0; i < visualStateGroups.Length; i++)
                                result.Add(visualStateGroups[i]);
                        }
                        break;

                    case 0x08: // End of an object
                        // (Nothing to do here)
                        break;

                    case 0x02: // End of collection
                        return result;

                    default:
                        throw new Exception(string.Format("Unrecognized character 0x{0:X2} while parsing object collection", controlByte));

                }
            }

            throw new Exception("Reached end of stream before finishing object collection");
        }

        private string GetTypeNameV2(int id)
        {
            if (id < TypeTable.Length)
                return TypeTable[id].Name;
            return XbfFrameworkTypes.GetNameForID(id) ?? string.Format("UnknownType0x{0:X4}", id);
        }

        private string GetPropertyNameV2(int id)
        {
            if (id < PropertyTable.Length)
                return PropertyTable[id].Name;
            return XbfFrameworkTypes.GetNameForID(id) ?? string.Format("UnknownProperty0x{0:X4}", id);
        }

        private string GetEnumerationValueV2(int enumID, int enumValue)
        {
            // TODO
            return string.Format("Enum(0x{0:X4})Value({1})", enumID, enumValue);
        }

        private object GetPropertyValueV2(BinaryReader reader)
        {
            byte valueType = reader.ReadByte();
            switch (valueType)
            {
                case 0x01: // bool value false
                    return false;

                case 0x02: // bool value true
                    return true;

                case 0x03: // float
                    return reader.ReadSingle();

                case 0x04: // int
                    return reader.ReadInt32();

                case 0x05: // string
                    return StringTable[reader.ReadUInt16()];

                case 0x06: // Thickness
                    float left = reader.ReadSingle();
                    float top = reader.ReadSingle();
                    float right = reader.ReadSingle();
                    float bottom = reader.ReadSingle();

                    // Attempt to combine values
                    if (left == right && top == bottom)
                    {
                        // If all values are equal, just return one value
                        if (left == top)
                            return left;

                        // If the left/right and top/bottom values are equal, return a simple "x,y" string
                        return string.Format("{0},{1}", left, top);
                    }

                    // Otherwise, just return all values as a string
                    return string.Format("{0},{1},{2},{3}", left, top, right, bottom);

                case 0x07: // GridLength
                    int gridLengthType = reader.ReadInt32();
                    float gridLengthValue = reader.ReadSingle();
                    switch (gridLengthType)
                    {
                        case 0: return "Auto";
                        case 1: return gridLengthValue;
                        case 2: return (gridLengthValue == 1) ? "*" : gridLengthValue + "*";
                        default: throw new Exception();
                    }

                case 0x08: // Color (or Brush?)
                    byte b = reader.ReadByte();
                    byte g = reader.ReadByte();
                    byte r = reader.ReadByte();
                    byte a = reader.ReadByte();
                    return Color.FromArgb(a, r, g, b);

                case 0x09: // Duration (as an in-line string)
                    return ReadString(reader);

                case 0x0B: // Enumeration
                    int enumID = reader.ReadUInt16();
                    int enumValue = reader.ReadInt32();
                    return GetEnumerationValueV2(enumID, enumValue);

                default:
                    throw new Exception(string.Format("Unrecognized value type 0x{0:X2}", valueType));
            }
        }
    }
}
