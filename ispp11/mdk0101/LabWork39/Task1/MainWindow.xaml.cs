using System;
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
        int currentPage = 1;
        int filesCount;
        int pageSize = 5;
        int maxPage;

        public MainWindow()
        {
            InitializeComponent();

            FirstButton.Content = "|<";
            PreviousButton.Content = "<";
            PageTextBox.Text = "1";
            ShowRows();
        }

        public void ShowRows()
        {
            PageTextBox.Text = currentPage.ToString();
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\0109\Desktop");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            DirectoryInfo[] directories = directory.GetDirectories("*", SearchOption.AllDirectories);

            maxPage = files.Count() / pageSize + 1;

            var result = directories
                .Select(directory => new { directory.Name, directory.CreationTime })
                .Union(files.Select(file => new { file.Name, file.CreationTime }));

            filesCount = result.Count();
            result = result.OrderBy(file => file.Name).Skip((currentPage - 1) * pageSize).Take(pageSize).ToList();
            ResultDataGrid.ItemsSource = result;
            StatusTextBlock.Text = $"Показано {result.Count()} из {filesCount} записей";
            MaxPage();
        }

        private void MaxPage()
        {
            if (maxPage == Convert.ToInt32(PageTextBox.Text))//
            {
                NextButton.IsEnabled = false;
                LastButton.IsEnabled = false;
            }
            else
            {
                NextButton.IsEnabled = true;
                LastButton.IsEnabled = true;
            }
            if (1 == Convert.ToInt32(PageTextBox.Text))
            {
                PreviousButton.IsEnabled = false;
                FirstButton.IsEnabled = false;
            }
            else
            {
                PreviousButton.IsEnabled = true;
                FirstButton.IsEnabled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Content)
            {
                case "|<":
                    currentPage = 1;
                    break;
                case "<":
                    currentPage -= 1;
                    break;
                case ">":
                    currentPage += 1;
                    break;
                case ">|":
                    currentPage = maxPage;
                    break;
            }
            ShowRows();
        }

        private void PageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PageTextBox.Text != "")
                currentPage = Convert.ToInt32(PageTextBox.Text);
            else
                currentPage = 1;
            MaxPage();
        }
    }
}
