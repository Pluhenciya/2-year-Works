using System;
using System.Data;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DataTable DataTable;
        public string TableName = "Book";

        public MainWindow()
        {
            InitializeComponent();

            MessageBox.Show(DataAccessLayer.ConnectionString.ToString());
            try
            {
                DataTable = DataAccessLayer.GetTableByName(TableName);
                sqlDataGrid.ItemsSource = DataAccessLayer.GetTableByName(TableName).DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(DataAccessLayer.GetScalar(queryTextBox.Text).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void ExecuteTableButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable = DataAccessLayer.GetTable(queryTextBox.Text);
                sqlDataGrid.ItemsSource = DataAccessLayer.GetTable(queryTextBox.Text).DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void ShowBookButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sqlDataGrid.ItemsSource = DataAccessLayer.GetBooks();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void CountRowsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(DataAccessLayer.ExecuteSqlCommand(queryTextBox.Text).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void UpdatePriceButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(DataAccessLayer.IsUpdatePrice(Convert.ToInt32(idBookTextBox.Text), Convert.ToDouble(newPriceTextBox.Text)).ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка в запросе");
            }
        }

        private void UpdateDataBaseButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataAccessLayer.UpdateTable(ref DataTable, TableName);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }


    }
}
