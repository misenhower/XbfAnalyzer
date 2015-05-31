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
        public int ConnectionID { get; set; }

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
            // Simple properties (to be displayed in-line)
            foreach (var property in Properties.Where(p => !(p.Value is XbfObject)))
                sb.AppendFormat(" {0}=\"{1}\"", property.Name, property.Value);

            // Get complex properties (to be displayed inside the object body
            var complexProperties = Properties.Where(p => p.Value is XbfObject).ToArray();

            // If we don't have any complex properties or children, just close the object and return it
            if (complexProperties.Length == 0 && Children.Count == 0)
            {
                sb.Append(" />");
                return sb.ToString();
            }

            // Go into object body
            sb.AppendLine(">");

            // Complex properties
            foreach (var property in complexProperties)
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
