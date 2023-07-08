using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task2
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
            List<FileInfo> result = files.ToList();
            if (FileTextBox.Text.Length > 0)
            {
                if (MoreRadioButton.IsChecked.Value)
                    result = files.Where(file => file.Length >= (long)Convert.ToInt32(FileTextBox.Text)).ToList();
                else if (MoreRadioButton.IsChecked.Value)
                    result = files.Where(file => file.Length <= (long)Convert.ToInt32(FileTextBox.Text)).ToList();
            }
            ResultDataGrid.ItemsSource = result;
            StatusTextBlock.Text = $"Показано {result.Count} из {fileCount} записей";
            if (result.Count == 0)
                StatusTextBlock.Text = "Результатов нет";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            DataFilter();
        }

        private void FileTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataFilter();
        }
    }
}
