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

namespace Lection2705
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

        private void progressButton_Click(object sender, RoutedEventArgs e)
        {
            if(dataProgressBar.Value + 10 <= dataProgressBar.Maximum) 
            {
                dataProgressBar.Value += 10;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyDialogWindow myDialog = new MyDialogWindow();
            if (myDialog.ShowDialog() == true)
                MessageBox.Show("Ok");
            else
                MessageBox.Show("Cancel");
            if (MessageBox.Show("Текст сообщения", "Заголовок окна", MessageBoxButton.OK, MessageBoxImage.Error) == MessageBoxResult.OK)
            {
                MessageBox.Show("Хи-хи-хи");
            }
        }
    }
}
