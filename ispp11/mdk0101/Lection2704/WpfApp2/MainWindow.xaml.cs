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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            canvas.Background = new SolidColorBrush(Colors.Beige);
            canvas.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 255));
            canvas.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xF0, 0x00, 0xFF));
        }
    }
}
