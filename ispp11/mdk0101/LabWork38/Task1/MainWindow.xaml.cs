using System;
using System.Collections.Generic;
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
        int fileCount;
        int countRows = 5;
        int pageSize = 5;

        public MainWindow()
        {
            InitializeComponent();

            ShowRows();
        }

        public void ShowRows()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\0109\Downloads");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            fileCount = files.Length;
            List<FileInfo> result = files.ToList();
            result = result.OrderBy(file => file.Name).Skip(0).Take(countRows).ToList();
            ResultDataGrid.ItemsSource = result;
            StatusTextBlock.Text = $"Показано {result.Count} из {fileCount} записей";
            IsManyRows();
        }

        private void IsManyRows()
        {
            if (countRows + pageSize <= fileCount)
                ShowButton.IsEnabled = true;
            else
                ShowButton.IsEnabled = false;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            ShowRows();
            countRows += pageSize;
        }

        private void RowsCountTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RowsCountTextBox.Text != "")
                pageSize = Convert.ToInt32(RowsCountTextBox.Text);
            IsManyRows();
        }
    }
}
