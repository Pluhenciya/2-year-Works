using System.Collections.Generic;
using System.Windows.Controls;

namespace Task1.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {

        public SettingsPage()
        {
            InitializeComponent();

            loginTextBox.Text = Properties.Settings.Default.login;
            passwordTextBox.Text = Properties.Settings.Default.password;
            emailTextBox.Text = Properties.Settings.Default.email;
        }

        private void SaveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Properties.Settings.Default.login = loginTextBox.Text;
            Properties.Settings.Default.password = passwordTextBox.Text;
            Properties.Settings.Default.email = emailTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
