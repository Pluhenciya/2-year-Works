using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Task3
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
            if (LessTextBox.Text.Length > 0 && MoreTextBox.Text.Length > 0)
            {
                if (LessCheckBox.IsChecked.Value)
                    result = result.Where(file => Convert.ToInt32(LessTextBox.Text) >= file.Length);
                if (MoreCheckBox.IsChecked.Value)
                    result = result.Where(file => Convert.ToInt32(MoreTextBox.Text) <= file.Length);
            }
            ResultDataGrid.ItemsSource = result.ToList();

            StatusTextBlock.Text = $"Показано {result.ToList().Count} из {fileCount} записей";
            if (result.ToList().Count == 0)
                StatusTextBlock.Text = "Результатов нет";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataFilter();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            MoreTextBox.Text = string.Empty;
            LessTextBox.Text = string.Empty;
            MoreCheckBox.IsChecked = false;
            LessCheckBox.IsChecked = false;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            DataFilter();
        }
    }
}
