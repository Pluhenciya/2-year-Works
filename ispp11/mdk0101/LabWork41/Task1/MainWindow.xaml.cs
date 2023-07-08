using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DoubleAnimation menuAnimation = new DoubleAnimation();

        public MainWindow()
        {
            InitializeComponent();

            menuAnimation.Duration = TimeSpan.FromSeconds(1);
        }

        private void ShowMenuButton_Click(object sender, RoutedEventArgs e)
        {
            menuAnimation.From = MenuStackPanel.ActualWidth;
            menuAnimation.To = MenuStackPanel.ActualWidth == 45 ? 115 : 45;
            MenuStackPanel.BeginAnimation(StackPanel.WidthProperty, menuAnimation);
        }
    }
}
