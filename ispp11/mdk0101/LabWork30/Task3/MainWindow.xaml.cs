using System;
using System.Windows;
using System.Windows.Controls;

namespace Task3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FontSizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var radioButton = e.Source as RadioButton;
            if (radioButton.GroupName == "FontSize")
                Task3TextBox.FontSize = Convert.ToInt32(radioButton.Content);
        }

        private void LeftTextAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Task3TextBox.TextAlignment = TextAlignment.Left;
        }

        private void CenterTextAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Task3TextBox.TextAlignment = TextAlignment.Center;
        }

        private void RightTextAlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Task3TextBox.TextAlignment = TextAlignment.Right;
        }
    }
}
