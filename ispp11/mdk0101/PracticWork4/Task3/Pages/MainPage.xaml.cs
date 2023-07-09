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

namespace Task3.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AutorizationButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AutorizationPage());
        }

        private void ChangeThemButton_Click(object sender, RoutedEventArgs e)
        {
            if (Manager.userData[3] == "Dark")
            {
                Manager.theme = "Light";
            }
            else
            {
                Manager.theme = "Dark";
            }

            Manager.InstallTheme();
            Manager.userData[3] = Manager.theme;
            File.WriteAllLines(Manager.path, Manager.userData);
        }

    }
}
