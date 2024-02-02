using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFNotepad
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

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Open_File_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new();
            ofd.ShowDialog();

            if (ofd.FileName != null)
            {
                
            }
        }

        private void Exit_Program_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}