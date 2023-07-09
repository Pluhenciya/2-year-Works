using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;


namespace Task3.Pages
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
            if (loginTextBox.Text == Manager.userData[0] &&
                Manager.GetHash(passwordTextBox.Text) == Manager.userData[1])
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
