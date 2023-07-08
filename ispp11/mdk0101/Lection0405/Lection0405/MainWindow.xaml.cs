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

namespace Lection0405
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button button = new Button();
            button.Click += Button_Click1;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(MessageBox.Show("закрыть?", "вопрос", MessageBoxButton.YesNo, MessageBoxImage.Question)==MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            MessageBox.Show("closed");
        }

        private void Window_Initialized(object sender, EventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button= (Button)e.Source;
            MessageBox.Show(button.Content.ToString());
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void testTextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            //MessageBox.Show("testTextBox_TextInput");
        }

        private void testTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyboardDevice.Modifiers == ModifierKeys.Control || e.KeyboardDevice.Modifiers == ModifierKeys.Shift)
            {

            }

            if(e.Key == Key.A || e.Key==Key.Enter || e.Key == Key.NumPad1 || e.Key == Key.Left)
            {

            }
        }

        private void testTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("testTextBox_KeyUp");
        }

        private void testTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (testTextBox.Text.Contains(".") && e.Key == Key.OemComma)
            {
                e.Handled = true;
            }
        }

        private void testTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            double number;
            if (!Double.TryParse(e.Text, out number) && e.Text != "-")
            {
                e.Handled = true;
            }
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void DockPanel_MouseMove(object sender, MouseEventArgs e)
        {
            var element = (UIElement)sender;
            Point point = e.GetPosition(element);
            Title = $"{point.X}; {point.Y}";
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var element = sender as Label;
            DragDrop.DoDragDrop(element, element.Content, DragDropEffects.Copy);
        }

        private void TextBlock_Drop(object sender, DragEventArgs e)
        {
            var destination = (TextBlock)sender;
            destination.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void TextBox_Drop(object sender, DragEventArgs e)
        {
            var destination = (TextBox)sender;
            destination.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
