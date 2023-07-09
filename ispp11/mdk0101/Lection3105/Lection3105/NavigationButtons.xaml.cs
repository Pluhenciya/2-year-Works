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

namespace Lection3105
{
    /// <summary>
    /// Логика взаимодействия для NavigationButtons.xaml
    /// </summary>
    public partial class NavigationButtons : UserControl
    {
        public event RoutedEventHandler GoToFirst;
        public event RoutedEventHandler GoToLast;

        //public int CurrentPage { get; set; }



        public int CurrentPage
        {
            get { return (int)GetValue(CurrentPageProperty); }
            set { SetValue(CurrentPageProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentPage.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register("CurrentPage", typeof(int), typeof(NavigationButtons));



        public NavigationButtons()
        {
            InitializeComponent();
            //DataContext = this; на всякий случай
        }

        private void FirstButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentPage = 1;
            GoToFirst?.Invoke(sender, e);
        }

        private void LastButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentPage = 100;
            GoToLast?.Invoke(sender, e);
        }
    }
}
