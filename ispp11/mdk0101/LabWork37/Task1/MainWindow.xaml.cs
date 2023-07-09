using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataFilter();
        }

        public void DataFilter()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\0109\Downloads");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            int fileCount = files.Length;
            var result = files
                .Where(file => file.Name.Contains(FileTextBox.Text, System.StringComparison.OrdinalIgnoreCase))
                .ToList();
            ResultDataGrid.ItemsSource = result;
            StatusTextBlock.Text = $"Показано {result.Count} из {fileCount} записей";
            if (result.Count == 0)
                StatusTextBlock.Text = "Результатов нет";
        }

        private void FileTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataFilter();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            FileTextBox.Text = string.Empty;
        }
    }
}
