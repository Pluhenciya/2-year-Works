using System.Collections.Generic;
using System.Configuration;
using System.Windows.Controls;

namespace Task2.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {

        public SettingsPage()
        {
            InitializeComponent();

            loginTextBox.Text = ConfigurationManager.AppSettings.Get("login");
            passwordTextBox.Text = ConfigurationManager.AppSettings.Get("password");
            emailTextBox.Text = ConfigurationManager.AppSettings.Get("email");
        }

        private void SaveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["login"].Value = loginTextBox.Text;
            config.AppSettings.Settings["password"].Value = passwordTextBox.Text;
            config.AppSettings.Settings["email"].Value = emailTextBox.Text;
            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
