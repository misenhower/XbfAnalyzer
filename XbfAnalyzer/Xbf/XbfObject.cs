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

            // Split this object's properties into simple and complex (object) properties
            // Simple properties will be displayed in-line, and complex properties will be displayed in the object's body.
            var isComplexPropertyLookup = Properties.ToLookup(p => p.Value is XbfObject || p.Value is List<XbfObject>);
            var complexProperties = isComplexPropertyLookup[true].ToArray();
            var simpleProperties = isComplexPropertyLookup[false].ToArray();

            // If we have a small number of properties, just display them in-line
            if (simpleProperties.Length <= 4)
            {
                foreach (var property in simpleProperties)
                    sb.AppendFormat(" {0}=\"{1}\"", property.Name, property.Value);
            }
            // Otherwise, display each property on its own line
            else
            {
                foreach (var property in simpleProperties)
                    sb.AppendLine().AppendFormat(indent + _indent + "{0}=\"{1}\"", property.Name, property.Value);
            }

            // If we don't have any complex properties or children, just close the object and return it
            if (complexProperties.Length == 0)
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

                if (property.Value is XbfObject)
                {
                    sb.AppendLine(((XbfObject)property.Value).ToString(indentLevel + 2));
                }
                else
                {
                    foreach (var obj in (List<XbfObject>)property.Value)
                        sb.AppendLine(obj.ToString(indentLevel + 2));
                }


                sb.AppendFormat(indent + _indent + "</{0}>", propertyName);
                sb.AppendLine();
            }

            // Element closing
            sb.AppendFormat(indent + "</{0}>", TypeName);

            return sb.ToString();
        }
    }
}
