using System.Collections.Generic;
using System.Windows;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();

        public MainWindow()
        {
            InitializeComponent();

            users.Add(new User() { Id = 1, Login = "admin", Password = "1234" });
            users.Add(new User() { Id = 2, Login = "Pluhenciya", Password = "ugjgf" });
            users.Add(new User() { Id = 3, Login = "Graviton", Password = "87654" });
            users.Add(new User() { Id = 4, Login = "Ivan", Password = "03122004" });
            users.Add(new User() { Id = 5, Login = "Lesha", Password = "parol1234" });

            usersComboBox.ItemsSource = users;
            usersListBox.ItemsSource = users;
            usersListView.ItemsSource = users;
        }
    }
}
