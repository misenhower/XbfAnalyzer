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
        }

        #region Message Logging

        private void ClearLog()
        {
            OutputTextBox.Text = null;
        }

        private void LogMessage(string message = "")
        {
            OutputTextBox.Text += message + Environment.NewLine;
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

        #endregion
    }
}
