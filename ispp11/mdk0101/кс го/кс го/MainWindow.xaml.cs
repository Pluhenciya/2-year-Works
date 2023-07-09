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
using System.Windows.Threading;

namespace кс_го
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);
        DispatcherTimer timerMove = new DispatcherTimer(DispatcherPriority.Render);
        int result = 0;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Start();            
            timer.Tick += Timer_Tick;

            
            timerMove.Interval = TimeSpan.FromMilliseconds(1);
            timerMove.Start();
            timerMove.Tick += TimerMove_Tick;
        }

        private void TimerMove_Tick(object? sender, EventArgs e)
        {
            foreach (Ellipse enemy in gameCanvas.Children.OfType<Ellipse>())
            {
                double y = Canvas.GetTop(enemy);
                y = y + 1;
                Canvas.SetTop(enemy, y);
                if ( y >= Height)
                {
                    timerMove.Stop();
                    timer.Stop();
                    //MessageBox.Show("хахах слитый бот");
                    ResultLabel.Content = "хахахах слитый бот";
                    //ResultLabel.FontSize = 100;
                    ResultLabel.Foreground = new SolidColorBrush(Colors.Red);
                    break;


                }
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Ellipse enemy = new Ellipse();
            enemy.Width = 30;
            enemy.Height = 30;
            enemy.Fill = new SolidColorBrush(Colors.Lime);

            gameCanvas.Children.Add(enemy);

            double x = new Random().NextDouble() * Width;
            Canvas.SetLeft(enemy, x);
            Canvas.SetTop(enemy, -30);

            enemy.MouseDown += Enemy_MouseDown;
        }

        private void Enemy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            gameCanvas.Children.Remove(sender as UIElement);
            result = result + 1;
            ResultLabel.Content = $"Счёт {result}";
        }
    }
}
