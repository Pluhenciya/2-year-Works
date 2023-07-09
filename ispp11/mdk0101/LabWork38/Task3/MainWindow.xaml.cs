using System;
using System.Collections.Generic;
using System.IO;
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

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int currentPage = 1;
        int filesCount;
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
            filesCount = files.Length;
            List<FileInfo> result = files.ToList();
            result = result.OrderBy(file => file.Name).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            ResultDataGrid.ItemsSource = result;
            StatusTextBlock.Text = $"Показано {result.Count} из {filesCount} записей";
            MaxPage();
        }

        private void MaxPage()
        {
            if ((currentPage - 1) * pageSize >= filesCount)//
                ShowButton.IsEnabled = false;
            else
                ShowButton.IsEnabled = true;
        }

        private void ShowButton_Click(object sender, RoutedEventArgs e)
        {
            ShowRows();
        }

        private void PageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PageTextBox.Text != "")
                currentPage = Convert.ToInt32(PageTextBox.Text);
            else
                currentPage= 1;
            MaxPage();
        }
    }
}
