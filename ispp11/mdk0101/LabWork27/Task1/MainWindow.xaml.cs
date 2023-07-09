using System.Windows;
using System.Windows.Controls;
using Task1.Pages;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Manager.MainFrame = ContentFrame;
            Manager.MainFrame.Navigate(new MainPage());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void ContentFrame_ContentRendered(object sender, System.EventArgs e)
        {
            if (Manager.MainFrame.CanGoBack)
                backButton.Visibility = Visibility.Visible;
            else
                backButton.Visibility = Visibility.Collapsed;
        }
    }
}
