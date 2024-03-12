using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace WPFNotepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_File_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
                TextArea.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void Save_File_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                SaveFileDialog saveFileDialog = new();
                saveFileDialog.Filter = "Text file (*.txt)|*.txt|C# file (*.cs)|*.cs";

                if (saveFileDialog.ShowDialog() == true)
                    FilePath = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(saveFileDialog.FileName, TextArea.Text);
                }
                catch (Exception)
                {
                    InitializeComponent();
                }
            }
            else
            {
                File.WriteAllText(FilePath, TextArea.Text);
            }
        }

        private void Exit_Program_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}