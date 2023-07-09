using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task4
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

            var result = files.AsEnumerable();
            if (DateCheckBox.IsChecked.Value)
                result = result.Where(file => SelectDatePicker.DisplayDate < file.LastAccessTime);
            ResultDataGrid.ItemsSource = result.ToList();

            StatusTextBlock.Text = $"Показано {result.ToList().Count} из {fileCount} записей";
            if (result.ToList().Count == 0)
                StatusTextBlock.Text = "Результатов нет";
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            SelectDatePicker.DisplayDate = DateTime.Now;
            DateCheckBox.IsChecked = false;
        }

        private void DateCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            DataFilter();
        }

        private void SelectDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DataFilter();
        }
    }
}
