using System;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Логика взаимодействия для SqlWindow.xaml
    /// </summary>
    public partial class SqlWindow : Window
    {
        public SqlWindow()
        {
            InitializeComponent();
        }

        private void GetCountBooksButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(DataAccessLayer.GetCountBooksLessPrice(Convert.ToDouble(priceTextBox.Text)).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void ExecuteSqlCommandInsertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(DataAccessLayer.ExecuteSqlCommandInsert(commandTextBox.Text).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void GetBooksLessPriceByGenre_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                contentDataGrid.ItemsSource = DataAccessLayer.GetBooksLessPriceByGenre(Convert.ToDouble(priceFilterTextBox.Text), genreTextBox.Text).DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void UpdateBookById_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataAccessLayer.UpdateBookById(5, 1000, "Анекдоты");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }
    }
}
