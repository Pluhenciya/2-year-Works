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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool isDarkTheme = false;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void ChangeThemButton_Click(object sender, RoutedEventArgs e)
        {
            string theme;
            if (isDarkTheme)
            {
                theme = "Light";
                isDarkTheme= false;
            }
            else
            {
                theme = "Dark";
                isDarkTheme = true;
            }

            var uri = new Uri($"Themes/{theme}Them.xaml", UriKind.RelativeOrAbsolute);
            ResourceDictionary dict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(dict);
        }
    }
}
