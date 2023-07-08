using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Task4
{
    /// <summary>
    /// Логика взаимодействия для AutorizationWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text == "admin" && PasswordBox.Password == "qwerty")
            {
                AdminWindow adminWindow = new AdminWindow();
                Hide();
                adminWindow.ShowDialog();
                ShowDialog();
            }
            else if (LoginTextBox.Text == "manager" && PasswordBox.Password == "12345")
            {
                ManagerWindow managerWindow = new ManagerWindow();
                Hide();
                managerWindow.ShowDialog();
                ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
