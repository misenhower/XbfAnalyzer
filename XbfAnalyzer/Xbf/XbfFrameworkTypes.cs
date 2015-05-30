using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbfAnalyzer.Xbf
{
    public static class XbfFrameworkTypes
    {
        public static string GetNameForID(int id)
        {
            // I have not been able to find a source for mapping the built-in framework type names to their XBF v2 IDs.
            // This is just a collection of type names I've found by generating and analyzing files.

            switch (id)
            {
                // Objects
                case 0x81EB: return "UserControl";
                case 0x81BA: return "Grid";
                case 0x818C: return "TextBlock";
                case 0x81E3: return "TextBox";
                case 0x811E: return "Border";
                case 0x821C: return "Button";
                case 0x8109: return "SolidColorBrush";
                case 0x8234: return "Binding";
                case 0x80EF: return "x:Null";

                // Properties
                case 0x8310: return "FontSize"; // for a TextBlock ?
                case 0x8224: return "FontSize"; // for a UserControl ?
                case 0x8320: return "Text";
                case 0x81DC: return "Color";
                case 0x8340: return "Content";
                case 0x8138: return "Visibility";
                case 0x8228: return "Foreground";
                case 0x8287: return "Background";

                // Unknown
                default: return null;
            }
        }
    }
}
