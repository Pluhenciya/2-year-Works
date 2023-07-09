using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Windows.Controls;

namespace Task3.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {

        public SettingsPage()
        {
            InitializeComponent();

            loginTextBox.Text = Manager.userData[0];
            passwordTextBox.Text = Manager.userData[1];
            emailTextBox.Text = Manager.userData[2];
        }

        private void SaveButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Manager.userData[0] = loginTextBox.Text;
            Manager.userData[1] = Manager.GetHash(passwordTextBox.Text);
            Manager.userData[2] = emailTextBox.Text;
            File.WriteAllLines(Manager.path, Manager.userData);
        }
    }
}
