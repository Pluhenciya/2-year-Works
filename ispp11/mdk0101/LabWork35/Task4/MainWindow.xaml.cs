using Microsoft.Win32;
using System.Windows;

namespace Task4
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

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Изображение|*.png;*.jpg;*.jpeg;*.bmp";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == true)
            {
                ImagesListView.ItemsSource = openFileDialog.FileNames;
            }
        }
    }
}
