using System.Windows;
using System.Windows.Controls;

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

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            string text = "Вы выбрали:";
            bool isSelectedSection = false;
            foreach (CheckBox item in SectionListBox.Items)
            {
                if (item.IsChecked == true)
                {
                    text += $" {item.Content.ToString().ToLower()}";
                    isSelectedSection = true;
                }
            }
            if (isSelectedSection)
            {
                text += ".";
                MessageBox.Show(text);
            }
        }
    }
}
