using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] dataComboBox = { "сегодня", "за последнюю неделю", " в этом месяце" };
        public MainWindow()
        {
            InitializeComponent();

            DataFilter();
            DateComboBox.ItemsSource = dataComboBox;
        }

        public void DataFilter(int id=-1)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\0109\Downloads");
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
            int fileCount = files.Length;

            var result = files.AsEnumerable();
            switch(id)
            {
                case 0:
                    result = result.Where(file => file.CreationTime == DateTime.Today);
                    break;
                case 1:
                    result = result.Where(file => ISOWeek.GetWeekOfYear(file.CreationTime.Date) == ISOWeek.GetWeekOfYear(DateTime.Now));
                    break;
                case 2:
                    result = result.Where(file => file.CreationTime.Year == DateTime.Today.Year && file.CreationTime.Month == DateTime.Today.Month);
                    break;
                default:
                    break;
            }
            ResultDataGrid.ItemsSource = result.ToList();

            StatusTextBlock.Text = $"Показано {result.ToList().Count} из {fileCount} записей";
            if (result.ToList().Count == 0)
                StatusTextBlock.Text = "Результатов нет";
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            DataFilter();
        }

        private void DateComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataFilter(DateComboBox.SelectedIndex);
        }
    }
}
