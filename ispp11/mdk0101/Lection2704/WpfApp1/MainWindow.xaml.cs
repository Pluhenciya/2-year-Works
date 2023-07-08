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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Обращение к ресурсам
            var uri1 = new Uri(@"pack://application:,,,/images/zombie.png");
            rect1.Fill = new ImageBrush(new BitmapImage(uri1));

            //Обращение к файлу с тем же путём
            var uri2 = new Uri(@"C:\Temp\ispp11\mdk0101\Lection2704\WpfApp1\Images\plant.png");
            rect2.Fill = new ImageBrush(new BitmapImage(uri2));

            var uri3 = new Uri("plant.png", UriKind.RelativeOrAbsolute);
            rect3.Fill = new ImageBrush(new BitmapImage(uri3));
        }
    }
}
