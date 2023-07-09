using Microsoft.Win32;
using System.IO;
using System.Windows;

namespace Task1
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
            openFileDialog.Filter =
                "Текстовый файл|*.txt|Код С#|cs|Html-документ|*.html|Css-файл|*.css|Код JavaScript|*.js|Код SQL|*.sql";
            if (openFileDialog.ShowDialog() == true)
            {
                ContentTextBox.Text = File.ReadAllText(openFileDialog.FileName);
                Title = openFileDialog.FileName;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
                "Текстовый файл|*.txt|Код С#|cs|Html-документ|*.html|Css-файл|*.css|Код JavaScript|*.js|Код SQL|*.sql";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, ContentTextBox.Text);
                MessageBox.Show("Файл сохранен");
            }
        }

        private void NotepadWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Вы хотите закрыть приложение?", "Потверждение", MessageBoxButton.YesNo,
                MessageBoxImage.Question) != MessageBoxResult.Yes)
                e.Cancel = true;
        }
    }
}
