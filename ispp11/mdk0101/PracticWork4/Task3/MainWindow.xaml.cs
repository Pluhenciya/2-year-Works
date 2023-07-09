using System;
using System.Collections.Generic;
using System.IO;
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
using Task3.Pages;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Manager.InstallTheme();
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
