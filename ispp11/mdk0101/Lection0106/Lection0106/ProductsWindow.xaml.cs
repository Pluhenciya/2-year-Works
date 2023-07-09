using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Lection0106
{
    /// <summary>
    /// Логика взаимодействия для ProductsWindow.xaml
    /// </summary>
    public partial class ProductsWindow : Window
    {
        ObservableCollection<Product> products = new ObservableCollection<Product>();
        List<Product> list = new List<Product>();
        Random random = new Random();
        public ProductsWindow()
        {
            InitializeComponent();

            for (int i = 1; i < 6; i++)
            {
                list.Add(new Product
                {
                    Id = i,
                    Name = $"product {i}",
                    Price = random.Next(1000)
                });
            }
            products = new ObservableCollection<Product>(list);

            ProductsDataGrid.ItemsSource = products;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product
            {
                Id = products.Max(p => p.Id) + 1,
                Name = "123"
            });
            ProductsDataGrid.ItemsSource = products;
        }
    }
}
