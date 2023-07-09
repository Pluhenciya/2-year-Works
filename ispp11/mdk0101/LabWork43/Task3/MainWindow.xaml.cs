using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);

        double ballXSpeed = new Random().NextDouble();
        double ballYSpeed = new Random().NextDouble();

        public MainWindow()
        {
            InitializeComponent();

            Canvas.SetTop(ballEllipse, new Random().Next((int)(gameCanvas.ActualHeight - ballEllipse.ActualHeight)));
            Canvas.SetLeft(ballEllipse, new Random().Next((int)(gameCanvas.ActualWidth - ballEllipse.ActualWidth)));
            timer.Interval = TimeSpan.FromMilliseconds(1);
            timer.Start();
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            double y = (double)ballEllipse.GetValue(Canvas.TopProperty);
            double x = (double)ballEllipse.GetValue(Canvas.LeftProperty);
            Canvas.SetTop(ballEllipse, y + ballYSpeed);
            Canvas.SetLeft(ballEllipse, x + ballXSpeed);
            if (y >= gameCanvas.Width)
            {
                timer.Stop();
                MessageBox.Show("End");
            }
        }
    }
}
