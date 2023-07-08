using System;
using System.Windows;
using System.Windows.Threading;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer(DispatcherPriority.Render);
        int cookies = 0;
        int grandmas = 0;
        int price = 15;

        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000);
            timer.Start();

            GrandmasRectangle.IsEnabled = false;
            GrandmasRectangle.Opacity = 0.5;
        }

        void Timer_Tick(object sender, EventArgs e)
        {
            cookies++;
            AddCookie();
        }

        private void CookiesEllipse_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cookies++;
            AddCookie();
        }

        private void AddCookie()
        {
            CookiesLabel.Content = cookies;
            GrandmasRectangle.IsEnabled = (cookies >= price);
            GrandmasRectangle.Opacity = (cookies >= price) ? 1 : 0.5;
        }

        private void GrandmasRectangle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            cookies -= price;
            AddCookie();
            grandmas++;
            GrandmasLabel.Content = grandmas;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1000 / (grandmas + 1));
            timer.Start();
        }
    }
}
