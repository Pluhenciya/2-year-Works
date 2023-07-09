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
        }

        private void ChangeBackgroundCheckBox_Click(object sender, RoutedEventArgs e)
        {
            ChangeBackground();
        }

        private void ChangeBackgroundSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ChangeBackground();
        }

        private void ChangeBackground()
        {
            var red = RedCheckBox.IsChecked.Value ? RedSlider.Value : 0;
            var green = GreenCheckBox.IsChecked.Value ? GreenSlider.Value : 0;
            var blue = BlueCheckBox.IsChecked.Value ? BlueSlider.Value : 0;
            Background = new SolidColorBrush(Color.FromRgb((byte)red, (byte)green, (byte)blue));
        }
    }
}
