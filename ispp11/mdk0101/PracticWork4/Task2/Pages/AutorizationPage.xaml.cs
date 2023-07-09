using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace Task2.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void EntranceButton_Click(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text == ConfigurationManager.AppSettings.Get("login")
                && passwordTextBox.Text == ConfigurationManager.AppSettings.Get("password"))
            {
                Manager.MainFrame.Navigate(new SettingsPage());
            }
            else
            {
                warningLabel.Visibility = Visibility.Visible;
            }
        }
    }
}
