using System;
using System.Collections.Generic;
using System.Data;
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

namespace Lection0106
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string HexColor { get; set; }

        public DateTime Date { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            
            Date= DateTime.Now;
            DataContext = this;
            Product product= new Product();
            product.CreationDate = DateTime.Now;
            product.Price = 456.34;
            DataContext = product;
        }

        private void RGBTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            HexColor = $"#{RedTextBox.Text}{GreenTextBox.Text}{BlueTextBox.Text}";
        }

        private void IdTextBox_Error(object sender, ValidationErrorEventArgs e)
        {

        }
    }
}
