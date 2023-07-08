using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace Task1
{
    internal static class DataAccessLayer
    {
        public static string Database { get; set; } = "ispp1101";
        public static string Server { get; set; } = "PRSERVER\\SQLEXPRESS";
        public static string Login { get; set; } = "ispp1101";
        public static string Password { get; set; } = "1101";

        public static string ConnectionString
        {
            get
            {
                var builder = new SqlConnectionStringBuilder
                {
                    DataSource = Server,
                    UserID = Login,
                    Password = Password,
                    TrustServerCertificate = true,
                    InitialCatalog = Database
                };
                return builder.ConnectionString;
            }
        }

        public static object GetScalar(string query)
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            return sqlCommand.ExecuteScalar();
        }

        public static DataTable GetTable(string query)
        {
            DataTable dataTable = new DataTable();
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            using SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static List<Book> GetBooks()
        {
            string query = "SELECT * FROM Book";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            var reader = sqlCommand.ExecuteReader();
            List<Book> books = new List<Book>();
            while (reader.Read())
            {
                var book = new Book()
                {
                    Id = Convert.ToInt32(reader["idBook"]),
                    Title = reader["Title"].ToString(),
                    Price = Convert.ToDouble(reader["Price"])
                };
                books.Add(book);
            }
            return books;
        }

        public static int ExecuteSqlCommand(string query)
        {
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            return sqlCommand.ExecuteNonQuery();
        }

        public static bool IsUpdatePrice(int id, double price)
        {
            string query = $"UPDATE Book SET Price={price.ToString().Replace(",", ".")} WHERE IdBook={id}";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            return sqlCommand.ExecuteNonQuery() > 0;
        }

        public static DataTable GetTableByName(string table)
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataTable = new DataTable();
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            using SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static void UpdateTable(ref DataTable dataTable, string table)
        {
            string query = $"SELECT * FROM {table}";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            using SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            sqlDataAdapter.Update(dataTable);
            dataTable.Clear();
            sqlDataAdapter.Fill(dataTable);
        }

        public static int GetCountBooksLessPrice(double maxPrice)
        {
            string query = $"SELECT COUNT(*) FROM Book WHERE price < @maxPrice";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@maxPrice", maxPrice);
            return Convert.ToInt32(sqlCommand.ExecuteScalar());
        }

        public static int ExecuteSqlCommandInsert(string query)
        {
            query += ";SET @id=SCOPE_IDENTITY()";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            SqlParameter sqlParameter = new SqlParameter("@id", SqlDbType.Int);
            sqlParameter.Direction = ParameterDirection.Output;
            sqlCommand.Parameters.Add(sqlParameter);
            sqlCommand.ExecuteNonQuery();
            return Convert.ToInt32(sqlCommand.Parameters["@id"].Value);
        }

        public static DataTable GetBooksLessPriceByGenre(double price, string genre)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM Book WHERE (price < @price) AND (genre = @genre)";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@price", price);
            sqlCommand.Parameters.AddWithValue("@genre", genre);
            using SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }

        public static void UpdateBookById(int id, double price, string title)
        {
            string query = $"UPDATE Book SET price = @price, title = @title WHERE idBook = @id";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            sqlCommand.Parameters.AddWithValue("@price", price);
            sqlCommand.Parameters.AddWithValue("@title", title);
            if (sqlCommand.ExecuteNonQuery() > 0)
                MessageBox.Show("Книга изменена");
        }

        public static string SimpleInsertAuthor(string surname, string name, string country)
        {
            string query = $"Simple_Insert_Author @surname, @name, @country";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@surname", surname);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@country", country);
            if (sqlCommand.ExecuteNonQuery() > 0)
                return "Автор добавлен";
            else
                return "Автор не добавлен";
        }

        public static int InsertGetIdAuthor(string surname, string name, string country)
        {
            string query = $"Insert_Get_Id_Author @surname, @name, @country";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@surname", surname);
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Parameters.AddWithValue("@country", country);
            return Convert.ToInt32(sqlCommand.ExecuteScalar());
        }

        public static DataTable SelectBookByPrice(double startPrice, double endPrice)
        {
            DataTable dataTable = new DataTable();
            string query = $"Select_Book_By_Price @startPrice, @endPrice";
            using SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@startPrice", startPrice);
            sqlCommand.Parameters.AddWithValue("@endPrice", endPrice);
            using SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            return dataTable;
        }
    }
}
