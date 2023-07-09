using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Category> categories = new List<Category>
        {
             new Category{Name = "головоломка", Description = "описание жанра головоломка"},
             new Category{Name = "платформер", Description = "описание жанра платформер"},
             new Category{Name = "RPG", Description = "описание жанра RPG"},
             new Category{Name = "аркада", Description = "описание жанра аркада"}
        };

        List<Game> games = new List<Game>
        {
             new Game{IdGame = 1, Name = "Tetris", Price = 150, SalePercent = 5},
             new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Price = 10},
             new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Price = 300},
             new Game{IdGame = 4, Name = "Arkanoid", Price = 400, SalePercent = 5},
             new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Price = 1000},
             new Game{IdGame = 6, Name = "Tetris2", Price = 150, SalePercent = 10},
             new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Price = 10},
             new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Price = 300},
             new Game{IdGame = 9, Name = "Arkanoid2", Price = 400, SalePercent = 3},
             new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Price = 1000},
        };
        Random random= new Random();

        public MainWindow()
        {
            InitializeComponent();

            foreach (var game in games)
            {
                game.GameCategory = categories.ToArray()[random.Next(3)];
            }

            GamesDataGrid.ItemsSource = games;

            CategoriesComboBox.ItemsSource = categories;
        }
    }
}
