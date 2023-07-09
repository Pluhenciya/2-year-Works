using System;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для LabWork48Window.xaml
    /// </summary>
    public partial class LabWork48Window : Window
    {
        public LabWork48Window()
        {
            InitializeComponent();
        }

        private void SimpleInsertAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(DataAccessLayer.SimpleInsertAuthor("Аxматова", "Анна", "Россия"));
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void InsertGetIdAuthorBuuton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(DataAccessLayer.InsertGetIdAuthor("Каренина", "Анна", "Россия").ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void SelectBookByPriceButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                contentDataGrid.ItemsSource = DataAccessLayer.SelectBookByPrice(100, 1000).DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
