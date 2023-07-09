using System.Windows;
using System.Windows.Controls;
using Lection2604.Pages;

namespace Lection2604
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public static Frame MainFrame { get; set; }

        public Window1()
        {
            InitializeComponent();

            MainFrame = ContentFrame;
            ContentFrame.Navigate(new Page1());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page2());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Page3());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.GoBack();
        }

        private void ContentFrame_ContentRendered(object sender, System.EventArgs e)
        {
            button1.IsEnabled = MainFrame.CanGoBack;

            if(MainFrame.CanGoBack)
                button1.Visibility= Visibility.Visible;
            else
                button1.Visibility= Visibility.Collapsed;
        }
    }
}
