using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);
        DispatcherTimer timerMove = new DispatcherTimer(DispatcherPriority.Render);

        int score = 0;

        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromMilliseconds(500);
            timer.Start();
            timer.Tick += Timer_Tick;

            timerMove.Interval = TimeSpan.FromMilliseconds(50);
            timerMove.Start();
            timerMove.Tick += TimerMove_Tick;

            scoreLabel.Content = 0;
        }

        private void TimerMove_Tick(object? sender, EventArgs e)
        {
            foreach (Shape item in gameCanvas.Children.OfType<Shape>())
            {
                double y = (double)item.GetValue(Canvas.TopProperty);
                Canvas.SetTop(item, y + 3);
                if (y >= 400)
                {
                    timerMove.Stop();
                    timer.Stop();
                    MessageBox.Show("End");
                    break;
                }
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            Ellipse enemy = new Ellipse
            {
                Width = 30,
                Height = 30,
                Fill = new SolidColorBrush(Colors.Purple),
            };
            gameCanvas.Children.Add(enemy);
            
            double x = new Random().NextDouble() * Width - enemy.Width;
            Canvas.SetLeft(enemy, x);
            Canvas.SetTop(enemy, -enemy.Height/2);

            enemy.MouseDown += Enemy_MouseDown;
        }

        private void Enemy_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            gameCanvas.Children.Remove(sender as UIElement);

            score = score + 1;
            scoreLabel.Content = score;
        }
    }
}
