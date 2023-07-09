using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int diameter = random.Next(500);
            Ellipse round = new Ellipse();

            round.Fill = new SolidColorBrush(Color.FromRgb((byte)random.Next(255), (byte)random.Next(255), (byte)random.Next(255)));
            round.Width = diameter;
            round.Height = diameter;

            Canvas.SetTop(round, e.GetPosition(ContentCanvas).Y - diameter / 2);
            Canvas.SetLeft(round, e.GetPosition(ContentCanvas).X - diameter / 2);
            ContentCanvas.Children.Add(round);
        }
    }
}
