using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            }
        }

        public XbfHeader Header { get; private set; }
        public string[] StringTable { get; private set; }
        public XbfAssembly[] AssemblyTable { get; private set; }
        public XbfTypeNamespace[] TypeNamespaceTable { get; private set; }
        public XbfType[] TypeTable { get; private set; }
        public XbfProperty[] PropertyTable { get; private set; }
        public string[] XmlNamespaceTable { get; private set; }

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
    }
}
