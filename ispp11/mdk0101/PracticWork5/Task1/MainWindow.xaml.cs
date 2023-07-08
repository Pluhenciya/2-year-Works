using System;
using System.Collections.Generic;
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

            ValueSelectCount.MaxValue = 5;

            PriceTextBox.Text = "1";
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Title = (sender as RadioButton).Content.ToString();
        }

        private void ValueSelectCount_ValueChanged(object sender, RoutedEventArgs e)
        {
            ChangeCost();
        }

        private void ChangeCost()
        {
            CostLabel.Content = Convert.ToInt32(PriceTextBox.Text) * Convert.ToInt32(ValueSelectCount.Value);
        }

        private void PriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ChangeCost();
        }
    }
}
