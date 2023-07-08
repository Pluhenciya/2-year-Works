using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows;


namespace Lection0906
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataTable table = new DataTable();
        public MainWindow()
        {
            InitializeComponent();

            SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "PRSERVER\\SQLEXPRESS", // "*.\SQLEXPRESS"
                UserID = "ispp1101",
                Password = "1101",
                TrustServerCertificate = true,
                InitialCatalog = "ispp1101" //БД
            };

            string connString = connBuilder.ConnectionString;

            using SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            //работа с БД. conn.Close(); - не нужен
            string selectQuery = "SELECT * FROM Games";

            using SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);
            adapter.Fill(table);//Fill - заполнение таблицы
            grid.ItemsSource = table.DefaultView;//DefaultView - для отображения

            //SqlCommand command = new SqlCommand(query, conn);
            //var reader = command.ExecuteReader();

            //string columnNames = "";
            //for (int i = 0; i < reader.FieldCount; i++)
            //{
            //    columnNames += $"{reader.GetName(i)};";
            //}
            //MessageBox.Show(columnNames);

            //List<Game> games = new List<Game>();
            //if (reader.HasRows)
            //{
            //    int columnsCount = reader.FieldCount;
            //    while (reader.Read())
            //    {
            //        //object[] cells = new object[columnsCount];
            //        //reader.GetValues(cells);
            //        //var cell1 = reader.GetValue(1);
            //        //var cell2 = reader.GetString(1);
            //        var game = new Game()
            //        {
            //            Name = reader["name"].ToString(),
            //            Price = Convert.ToDouble(reader["price"])
            //        };
            //        games.Add(game);
            //        var cell3 = reader["name"];

            //        //if (reader["description"] != DBNull.Value)
            //        //{
            //        //    var cell4 = reader["description"].ToString();
            //        //}
            //    }
            //    grid.ItemsSource = games;
            //}
            //else
            //    MessageBox.Show("Has not Rows");
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SqlConnectionStringBuilder connBuilder = new SqlConnectionStringBuilder
            {
                DataSource = "PRSERVER\\SQLEXPRESS", // "*.\SQLEXPRESS"
                UserID = "ispp1101",
                Password = "1101",
                TrustServerCertificate = true,
                InitialCatalog = "ispp1101" //БД
            };

            string connString = connBuilder.ConnectionString;

            using SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            double price = 1000.5;
            string category = "RPG";
            //string query = $"select * from games where price = {price}";
            //string query = $"select * from games where price < @maxPrice";
            //string query = $"select * from games where category = {category}";
            //string query = $"select * from games where category = @category";
            //string query = "set @a=2+3";
            string query = "Sample_Procedure";

            SqlCommand command = new SqlCommand(query, conn);

            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@param2", 123);
            var result = command.ExecuteScalar();

            MessageBox.Show(result.ToString());

            //SqlParameter parameter = new SqlParameter("@a", SqlDbType.Decimal);
            //parameter.Direction = ParameterDirection.Output;
            //command.Parameters.Add(parameter);

            //command.ExecuteNonQuery();
            //MessageBox.Show(parameter.Value.ToString());

            //command.Parameters.AddWithValue("@maxPrice", price);

            //command.Parameters.AddWithValue("@category", category);

            //SqlParameter parameter = new SqlParameter("@maxPrice", SqlDbType.Decimal);
            //parameter.Value = price;
            //command.Parameters.Add(parameter);

            //SqlDataAdapter adapter1 = new SqlDataAdapter(command);
            //adapter1.Fill(table);

            //работа с БД. conn.Close(); - не нужен
            string selectQuery = "SELECT * FROM Games";

            using SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);
            using SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
            adapter.Update(table);
            table.Clear();
            adapter.Fill(table);

            MessageBox.Show(commandBuilder.GetInsertCommand().CommandText);
            MessageBox.Show(commandBuilder.GetUpdateCommand().CommandText);
            MessageBox.Show(commandBuilder.GetDeleteCommand().CommandText);
        }
    }
}
