using System.Windows;

namespace Task2
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

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (ItemTextBox.Text == "")
            {
                ShowListBox.Items.Add(ItemTextBox.Text);
                ShowComboBox.Items.Add(ItemTextBox.Text);
            }
        }
    }
}
