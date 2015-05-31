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
            using (var reader = new BinaryReader(fileStream, Encoding.Unicode))
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

        // XBF v2 node parser functionality is mostly based on analysis of XBF v2.1 files. There are probably a lot of mistakes here!
        private void ReadNodesV2(BinaryReader reader)
        {
            // There are 8 bytes at the beginning -- not sure what these are for.
            // Typical value: 0x0100000000000000;
            reader.ReadBytes(8);

            // Next we have the length of the nodes section. After that is line/position data.
            int nodeLength = reader.ReadInt32();
            int startPosition = (int)reader.BaseStream.Position;
            int endPosition = startPosition + nodeLength;

            XbfObject rootObject = new XbfObject();
            Stack<XbfObject> objectStack = new Stack<XbfObject>();
            objectStack.Push(rootObject);
            Dictionary<string, string> namespaces = new Dictionary<string, string>();

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
                                string name = XmlNamespaceTable[reader.ReadUInt16()];
                                string prefix = ReadString(reader);
                                namespaces[prefix] = name;
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
                            }
                            break;

                        case 0x14: // Normal object begin
                            {
                                XbfObject obj = new XbfObject();
                                obj.TypeName = GetTypeNameV2(reader.ReadUInt16());
                                objectStack.Push(obj);
                            }
                            break;

                        case 0x13: // Increasing depth?
                            {
                                // This seems to happen when increasing depth (i.e., descending into the children of an object).
                                // Not sure what we need to do here.

                                reader.ReadUInt16();
                            }
                            break;

                        case 0x21: // End object
                            {
                                // This should be followed by 0x08, 0x07, or 0x20, but these may not be present at the end of the node stream.
                                // I'm not sure if we need to do anything here
                            }
                            break;

                        case 0x08: // Add the last object to the children of the previous object
                            {
                                var obj = objectStack.Pop();
                                objectStack.Peek().Children.Add(obj);
                            }
                            break;

                        case 0x07: // Add the last object as a property of the previous object
                        case 0x20: // Same as 0x07, but this seems to occur when the object is a {Binding} value
                            {
                                var obj = objectStack.Pop();
                                string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                                objectStack.Peek().Properties.Add(new XbfObjectProperty(propertyName, obj));
                            }
                            break;

                        case 0x02: // This seems to happen at the end of a list of children. (Decreasing depth?)
                            break;

                        case 0x1A: // An object property
                        case 0x1B: // An object property (not sure what the difference from 0x1A is)
                            {
                                string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                                object propertyValue = GetPropertyValueV2(reader);
                                objectStack.Peek().Properties.Add(new XbfObjectProperty(propertyName, propertyValue));
                            }
                            break;

                        case 0x1E: // StaticResource
                            {
                                string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                                object propertyValue = GetPropertyValueV2(reader);
                                propertyValue = string.Format("{{StaticResource {0}}}", propertyValue);
                                objectStack.Peek().Properties.Add(new XbfObjectProperty(propertyName, propertyValue));
                            }
                            break;

                        case 0x24: // ThemeResource
                            {
                                string propertyName = GetPropertyNameV2(reader.ReadUInt16());
                                object propertyValue = GetPropertyValueV2(reader);
                                propertyValue = string.Format("{{ThemeResource {0}}}", propertyValue);
                                objectStack.Peek().Properties.Add(new XbfObjectProperty(propertyName, propertyValue));
                            }
                            break;

                        case 0x0C: // Indicates the object needs to be connected to something (e.g., a named variable, an event handler, etc.)
                            {
                                // This byte (0x0C) indicates the current object needs to be connected to something in the generated Connect method.
                                // This can include event handlers, named objects (to be accessed via instance variables), etc.
                                // Event handlers aren't explicitly included as part of the XBF node stream since they're wired up in (generated) code.
                                // Each object that needs to be connected to something has a unique ID indicated in this section.
                                // Example bytes: 0C 04 01 00 00 00

                                // I've only seen 0x04 as the first byte value -- this may be a byte count?
                                reader.ReadByte();
                                // Connection ID
                                objectStack.Peek().ConnectionID = reader.ReadInt32();
                            }
                            break;

                        case 0x0D: // x:Name
                            {
                                string name = GetPropertyValueV2(reader).ToString();
                                objectStack.Peek().Name = name;
                            }
                            break;

                        case 0x0E: // x:Uid
                            {
                                object value = GetPropertyValueV2(reader);
                                objectStack.Peek().Uid = value.ToString();
                            }
                            break;

                        default:
                            throw new Exception(string.Format("Unrecognized character 0x{0:X2} in node stream", controlByte));
                    }
                }
            }
            catch (Exception e)
            {
                NodeParserError = string.Format("Error parsing node stream at file position {0} (0x{0:X}) (node start position was: {1} (0x{1:X}))" + Environment.NewLine, reader.BaseStream.Position - 1, startPosition) + e.ToString();
            }

            if (rootObject != null)
                NodeResultString = rootObject.ToString();
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
            switch (reader.ReadByte())
            {
                case 0x01: // bool value false
                    return false;

                case 0x02: // bool value true
                    return true;

                case 0x03: // float
                    return reader.ReadSingle();

                case 0x05: // string
                    return StringTable[reader.ReadUInt16()];

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

                case 0x0B: // Enumeration
                    int enumID = reader.ReadUInt16();
                    int enumValue = reader.ReadInt32();
                    return GetEnumerationValueV2(enumID, enumValue);

                default:
                    throw new Exception();
            }
        }
    }
}
