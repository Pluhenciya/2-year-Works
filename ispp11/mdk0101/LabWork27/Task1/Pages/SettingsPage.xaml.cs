using System.Collections.Generic;
using System.Windows.Controls;

namespace Task1.Pages
{
    /// <summary>
    /// Логика взаимодействия для SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page
    {
        class Game
        {
            public double IdGame { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
        }

        class Category
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        List<Game> games = new List<Game>
        {
             new Game{IdGame = 1, Name = "Tetris", Category = "головоломка", Price = 150},
             new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
             new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
             new Game{IdGame = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
             new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
             new Game{IdGame = 6, Name = "Tetris2", Category = "головоломка", Price = 150},
             new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
             new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Category = "аркада", Price = 300},
             new Game{IdGame = 9, Name = "Arkanoid2", Category = "аркада", Price = 400},
             new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Category = "платформер", Price = 1000},
        };

        List<Category> categories = new List<Category>
        {
             new Category{Name = "головоломка", Description = "описание жанра головоломка"},
             new Category{Name = "платформер", Description = "описание жанра платформер"},
             new Category{Name = "RPG", Description = "описание жанра RPG"},
             new Category{Name = "аркада", Description = "описание жанра аркада"}
        };

        public SettingsPage()
        {
            InitializeComponent();

            foreach (var category in categories)
            {
                foreach (var game in games)
                {
                    Expander expander = new Expander();
                    expander.Header = category.Name;
                    GamesStackPanel.Children.Add(expander);
                    expander.Name = category.Name;
                    if (game.Category == category.Name)
                    {
                        CheckBox gameCheckBox = new CheckBox();
                        gameCheckBox.Content = game.Name;
                        //expander.Content += gameCheckBox;
                    }
                }
            }
        }
    }
}
