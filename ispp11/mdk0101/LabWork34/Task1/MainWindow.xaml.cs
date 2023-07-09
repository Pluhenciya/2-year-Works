using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<double> fontSize = new List<double>() { 8, 10, 12, 14, 16, 18, 20, 30, 40, 50 };

        public MainWindow()
        {
            InitializeComponent();

            DateTextBlock.Text = DateTime.Now.ToString();
            IsSearchedStatusBarMenuItem.IsChecked = true;
            FontSizeComboBox.ItemsSource = fontSize;
        }

        private void TextTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CountCharTextBlock.Text = $"Количество символов: {TextTextBox.Text.Length}";
        }

        private void IsSearchedStatusBarMenuItem_Checked(object sender, RoutedEventArgs e)
        {
            if (IsSearchedStatusBarMenuItem.IsChecked == true)
                WordStatusBar.Visibility = Visibility.Visible;
            else
                WordStatusBar.Visibility = Visibility.Collapsed;
        }

        private void ClearMenuItem_Click(object sender, RoutedEventArgs e)
        {
            TextTextBox.Clear();
        }

        private void ExitMenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FontSizeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FontSizeComboBox.SelectedItem != null)
                TextTextBox.FontSize = (double)FontSizeComboBox.SelectedItem;
        }

        private void ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ScaleTextBlock.Text = $"{Math.Round(ScaleSlider.Value)}%";
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuStackPanel.Width == 45)
                MenuStackPanel.Width = 110;
            else
                MenuStackPanel.Width = 45;
        }
    }
}
