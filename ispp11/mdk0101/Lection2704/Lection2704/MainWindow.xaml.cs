using System.Windows;
using System.Windows.Controls;

namespace Lection2704
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

        private void FilesExpander_Expanded(object sender, RoutedEventArgs e)
        {
            StackPanel panel = new StackPanel();
            for (int i = 0; i < 10; i++)
            {
                Label label = new Label();
                label.Content = $"File # {i+1}";
                panel.Children.Add(label);
            }
            FilesExpander.Content = panel;
        }

        private void FilesExpander_Collapsed(object sender, RoutedEventArgs e)
        {

        }
    }
}
