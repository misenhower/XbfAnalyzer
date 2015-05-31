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
                case 0x802C: return "ColumnDefinition";
                case 0x806A: return "RowDefinition";

                // Properties
                case 0x8310: return "FontSize"; // for a TextBlock ?
                case 0x8224: return "FontSize"; // for a UserControl ?
                case 0x8320: return "Text";
                case 0x81DC: return "Color";
                case 0x8340: return "Content";
                case 0x8138: return "Visibility";
                case 0x8228: return "Foreground";
                case 0x8287: return "Background";
                case 0x8199: return "Width"; // Grid
                case 0x805D: return "MaxWidth"; // ColumnDefinition
                case 0x805E: return "MinWidth"; // ColumnDefinition
                case 0x805F: return "Width"; // ColumnDefinition
                case 0x8189: return "Height"; // Grid
                case 0x80E3: return "Height"; // RowDefinition
                case 0x80E4: return "MaxHeight"; // RowDefinition
                case 0x80E5: return "MinHeight"; // RowDefinition

                // Unknown
                default: return null;
            }
        }
    }
}
