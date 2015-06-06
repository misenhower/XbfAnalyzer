using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XbfAnalyzer.Xbf
{
    public static class XbfFrameworkTypes
    {
        public static string GetNameForTypeID(int id)
        {
            // I have not been able to find a source for mapping the built-in framework type names to their XBF v2 IDs.
            // This is just a collection of type names I've found by generating and analyzing files.

            switch (id)
            {
                // Objects
                case 0x8024: return "x:Boolean";
                case 0x8034: return "x:Double";
                case 0x804C: return "x:Int32";
                case 0x8071: return "x:String";
                case 0x80EF: return "x:Null";
                case 0x81EB: return "UserControl";
                case 0x81BA: return "Grid";
                case 0x818C: return "TextBlock";
                case 0x81E3: return "TextBox";
                case 0x811E: return "Border";
                case 0x821C: return "Button";
                case 0x8109: return "SolidColorBrush";
                case 0x8234: return "Binding";
                case 0x802C: return "ColumnDefinition";
                case 0x806A: return "RowDefinition";
                case 0x808A: return "VisualStateGroup";
                case 0x8089: return "VisualState";
                case 0x8107: return "Setter";
                case 0x82F5: return "AdaptiveTrigger";
                case 0x82FF: return "StateTrigger";
                case 0x82E8: return "RelativePanel";
                case 0x8306: return "CalendarDatePicker";
                case 0x82C3: return "CalendarView";
                case 0x82C5: return "CalendarViewDayItem";
                case 0x81EF: return "AppBar";
                case 0x822D: return "AppBarButton";
                case 0x823A: return "GridView";
                case 0x81E1: return "StackPanel";
                case 0x8120: return "CaptureElement";
                case 0x8128: return "ContentPresenter";
                case 0x8146: return "Image";
                case 0x814C: return "ItemsPresenter";
                case 0x81AB: return "AppBarSeparator";
                case 0x822F: return "CheckBox";
                case 0x8236: return "ComboBox";
                case 0x81F6: return "CarouselPanel";
                case 0x821E: return "CommandBar";
                case 0x81FD: return "Frame";
                case 0x81B8: return "FontIcon";
                case 0x81E6: return "TickBar";
                case 0x81E7: return "TimePicker";
                case 0x8229: return "ToggleButton";
                case 0x822A: return "ToggleMenuFlyoutItem";
                case 0x81E9: return "ToggleSwitch";
                case 0x821A: return "ToolTip";
                case 0x81EC: return "VariableSizedWrapGrid";
                case 0x81A1: return "Viewbox";
                case 0x822B: return "VirtualizingStackPanel";
                case 0x81EE: return "WebView";
                case 0x822C: return "WrapGrid";
                case 0x8072: return "Style";
                case 0x80C2: return "DataTemplate";
                case 0x820D: return "Page";

                // Unknown
                default: return null;
            }
        }

        public static string GetNameForPropertyID(int id)
        {
            switch (id)
            {
                // Properties
                case 0x8310: return "FontSize"; // TextBlock
                case 0x8224: return "FontSize"; // Control
                case 0x8320: return "Text"; // TextBlock
                case 0x81DC: return "Color"; // SolidColorBrush
                case 0x8340: return "Content"; // ContentControl
                case 0x8138: return "Visibility"; // UIElement
                case 0x8228: return "Foreground"; // Control
                case 0x8314: return "Foreground"; // TextBlock
                case 0x8287: return "Background"; // Panel
                case 0x821D: return "Background"; // Control
                case 0x8199: return "Width"; // FrameworkElement
                case 0x805D: return "MaxWidth"; // ColumnDefinition
                case 0x805E: return "MinWidth"; // ColumnDefinition
                case 0x805F: return "Width"; // ColumnDefinition
                case 0x8189: return "Height"; // FrameworkElement
                case 0x80E3: return "Height"; // RowDefinition
                case 0x80E4: return "MaxHeight"; // RowDefinition
                case 0x80E5: return "MinHeight"; // RowDefinition
                case 0x835A: return "ColumnDefinitions"; // Grid
                case 0x835D: return "RowDefinitions"; // Grid
                case 0x8288: return "Children"; // Panel
                case 0x83E7: return "Content"; // UserControl
                case 0x8146: return "VisualStateManager.VisualStateGroups";
                case 0x818D: return "Margin"; // FrameworkElement
                case 0x8698: return "Padding"; // Grid
                case 0x81FD: return "Padding"; // Border
                case 0x8143: return "States"; // VisualStateGroup
                case 0x8616: return "Setters"; // VisualState
                case 0x8617: return "StateTriggers"; // VisualState
                case 0x861A: return "Target"; // Setter
                case 0x81DB: return "Value"; // Setter
                case 0x8618: return "MinWindowHeight"; // AdaptiveTrigger
                case 0x8619: return "MinWindowWidth"; // AdaptiveTrigger
                case 0x86A6: return "IsActive"; // StateTrigger
                case 0x8194: return "Resources"; // FrameworkElement
                case 0x80F7: return "Setters"; // Style
                case 0x80F4: return "BasedOn"; // Style

                // Unknown
                default: return null;
            }
        }
    }
}
