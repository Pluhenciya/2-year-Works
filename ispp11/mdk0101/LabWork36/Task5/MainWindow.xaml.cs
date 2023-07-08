using System.Windows;
using System.Windows.Media;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow Window { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Window = this;
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            BackgroundDialog backgroundDialog = new BackgroundDialog();
            if (backgroundDialog.ShowDialog() == true)
            {
                Background = new SolidColorBrush(backgroundDialog.BackgroundColor);
            }
        }
    }
}
