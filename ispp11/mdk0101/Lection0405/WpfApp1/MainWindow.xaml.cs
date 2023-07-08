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

        Point? dragStart = null;
        private void canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = e.Source as UIElement;
            dragStart = e.GetPosition(element);
            element.CaptureMouse();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragStart != null)
            {
                var element = (UIElement)e.Source;
                var dragFinish = e.GetPosition(canvas);
                Canvas.SetLeft(element, dragFinish.X - dragStart.Value.X);
                Canvas.SetTop(element, dragFinish.Y - dragStart.Value.Y);
            }
        }

        private void canvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            var element = (UIElement)e.Source;
            dragStart = null;
            element.ReleaseMouseCapture();
        }
    }
}
