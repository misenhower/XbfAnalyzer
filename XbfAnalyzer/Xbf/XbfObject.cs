using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbfAnalyzer.Xbf
{
    public class XbfObject
    {
        public string TypeName { get; set; }
        public string Name { get; set; }
        public string Uid { get; set; }

        private readonly List<XbfObjectProperty> _properties = new List<XbfObjectProperty>();
        public List<XbfObjectProperty> Properties { get { return _properties; } }

        private readonly List<XbfObject> _children = new List<XbfObject>();
        public List<XbfObject> Children { get { return _children; } }

        public override string ToString()
        {
            return ToString(0);
        }

        private const string _indent = "    ";

        public string ToString(int indentLevel)
        {
            string indent = string.Concat(Enumerable.Repeat(_indent, indentLevel));

            StringBuilder sb = new StringBuilder();

            // Element opening
            sb.AppendFormat(indent + "<{0}", TypeName);
            // Name
            if (Name != null)
                sb.AppendFormat(" x:Name=\"{0}\"", Name);
            // Uid
            if (Uid != null)
                sb.AppendFormat(" x:Uid=\"{0}\"", Uid);
            // Simple properties
            foreach (var property in Properties.Where(p => !(p.Value is XbfObject)))
                sb.AppendFormat(" {0}=\"{1}\"", property.Name, property.Value);
            sb.AppendLine(">");

            // Complex properties
            foreach (var property in Properties.Where(p => p.Value is XbfObject))
            {
                var propertyName = TypeName + "." + property.Name;
                sb.AppendFormat(indent + _indent + "<{0}>", propertyName);
                sb.AppendLine();

                sb.AppendLine(((XbfObject)property.Value).ToString(indentLevel + 2));

                sb.AppendFormat(indent + _indent + "</{0}>", propertyName);
                sb.AppendLine();
            }

            // Children
            foreach (var child in Children)
            {
                sb.AppendLine(child.ToString(indentLevel + 1));
            }

            // Element closing
            sb.AppendFormat(indent + "</{0}>", TypeName);

            return sb.ToString();
        }
    }
}
