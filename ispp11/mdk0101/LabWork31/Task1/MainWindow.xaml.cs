using System;
using System.Windows;
using System.Windows.Controls;

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

            BirthDatePicker.DisplayDateEnd = DateTime.Now;
        }

        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text != "" || UserPasswordBox.Password != "" || UserInfoTextBox.Text != ""
                && UserPasswordBox.Password == СonfirmationPasswordBox.Password)
                MessageBox.Show($"{LoginTextBox.Text}, вы зарегистрированы");
            else
                MessageBox.Show("Некорректные данные");
        }

        private void BirthDatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var age = DateTime.Now.Year - BirthDatePicker.DisplayDate.Year;
            if (BirthDatePicker.DisplayDate > DateTime.Now.AddYears(-age))
                age--;
            BirthLadel.Content = $"{age} лет";
        }
    }
}
