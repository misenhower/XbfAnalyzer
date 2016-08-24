using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using XbfAnalyzer.Xbf;

namespace XbfAnalyzer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_PreviewDragOver(object sender, DragEventArgs e)
        {
            e.Effects = DragDropEffects.Move;
            e.Handled = true;
        }

        private void Window_Drop(object sender, DragEventArgs e)
        {
            string[] droppedItems = e.Data.GetData(DataFormats.FileDrop) as string[];
            if (droppedItems == null || droppedItems.Length < 1)
                return;

            ClearLog();

            // Process each file
            foreach (var path in droppedItems)
                ProcessFile(path);
        }

        private void ProcessFile(string path)
        {
            LogBoldLine();
            LogMessage("File: " + path);

            try
            {
                var xbf = new XbfReader(path);

                // Header info
                LogMessage("File version: {0}.{1}", xbf.Header.MajorFileVersion, xbf.Header.MinorFileVersion);
                LogMessage("Metadata Size: {0} (0x{0:X})", xbf.Header.MetadataSize);
                LogMessage("Node Size: {0} (0x{0:X})", xbf.Header.NodeSize);
                // The offset values seem to be off by 12 bytes compared to the actual positions of these elements in the XBF files.
                // Displaying these as adjusted values to make external analysis easier.
                LogMessage("Adjusted String Table Offset: {0} (0x{0:X})", xbf.Header.StringTableOffset + 12);
                LogMessage("Adjusted Assembly Table Offset: {0} (0x{0:X})", xbf.Header.AssemblyTableOffset + 12);
                LogMessage("Adjusted Type Namespace Table Offset: {0} (0x{0:X})", xbf.Header.TypeNamespaceTableOffset + 12);
                LogMessage("Adjusted Type Table Offset: {0} (0x{0:X})", xbf.Header.TypeTableOffset + 12);
                LogMessage("Adjusted Property Table Offset: {0} (0x{0:X})", xbf.Header.PropertyTableOffset + 12);
                LogMessage("Adjusted XML Namespace Table Offset: {0} (0x{0:X})", xbf.Header.XmlNamespaceTableOffset + 12);
                LogMessage();

                // String table
                LogLine();
                LogMessage("String table:");
                for (int i = 0; i < xbf.StringTable.Length; i++)
                    LogHexAddressMessage(i, xbf.StringTable[i]);
                LogMessage();

                // Assembly table
                LogLine();
                LogMessage("Assembly table:");
                for (int i = 0; i < xbf.AssemblyTable.Length; i++)
                {
                    var assembly = xbf.AssemblyTable[i];
                    LogHexAddressMessage(i, "{0} (Kind: {1})", assembly.Name, assembly.Kind);
                }
                LogMessage();

                // Type namespace table
                LogLine();
                LogMessage("Type namespace table:");
                for (int i = 0; i < xbf.TypeNamespaceTable.Length; i++)
                {
                    var typeNamespace = xbf.TypeNamespaceTable[i];
                    LogHexAddressMessage(i, "{0} (Assembly: {1})", typeNamespace.Name, typeNamespace.Assembly.Name);
                }
                LogMessage();

                // Type table
                LogLine();
                LogMessage("Type table:");
                for (int i = 0; i < xbf.TypeTable.Length; i++)
                {
                    var type = xbf.TypeTable[i];
                    LogHexAddressMessage(i, "{0} (Namespace: {1}, Flags: {2})", type.Name, type.Namespace.Name, type.Flags);
                }
                LogMessage();

                // Property table
                LogLine();
                LogMessage("Property table:");
                for (int i = 0; i < xbf.PropertyTable.Length; i++)
                {
                    var property = xbf.PropertyTable[i];
                    LogHexAddressMessage(i, "{0} (Type: {1}, Flags: {2})", property.Name, property.Type.Name, property.Flags);
                }
                LogMessage();

                // XML namespace table
                LogLine();
                LogMessage("XML namespace table:");
                for (int i = 0; i < xbf.XmlNamespaceTable.Length; i++)
                    LogHexAddressMessage(i, xbf.XmlNamespaceTable[i]);
                LogMessage();

                // Node section table
                LogLine();
                LogMessage("Node section table:");
                for (int i = 0; i < xbf.NodeSectionTable.Length; i++)
                    LogHexAddressMessage(i, "Node offset: {0} (0x{0:X}) Positional offset: {1} (0x{1:X})", xbf.NodeSectionTable[i].NodeOffset, xbf.NodeSectionTable[i].PositionalOffset);
                LogMessage();

                // Nodes
                LogLine();
                if (xbf.Header.MajorFileVersion < 2)
                    LogMessage("Parsing XBF v1 nodes is not currently supported.");
                else
                {
                    string xaml = xbf.RootObject.ToString();
                    LogMessage("XAML objects:");              
                    LogMessage(xaml);
                }
            }
            catch (Exception ex)
            {
                LogMessage("Error: " + ex.ToString());
            }

            ShowLog();
        }

        #region Message Logging

        private StringBuilder log = new StringBuilder();

        private void ShowLog()
        {
            OutputTextBox.Text = log.ToString();
        }

        private void ClearLog()
        {
            log.Clear();
            OutputTextBox.Text = null;
        }

        private void LogMessage(string message = "")
        {
            log.AppendLine(message);
        }

        private void LogMessage(string format, params object[] args)
        {
            LogMessage(string.Format(format, args));
        }

        private void LogLine()
        {
            LogMessage(new string('-', 80));
        }

        private void LogBoldLine()
        {
            LogMessage(new string('=', 80));
        }

        private void LogHexAddressMessage(int address, string message)
        {
            LogMessage("{0:X4}: {1}", address, message);
        }

        private void LogHexAddressMessage(int address, string format, params object[] args)
        {
            LogHexAddressMessage(address, string.Format(format, args));
        }

        #endregion
    }
}
