namespace Lection0303
{
    public partial class Form1 : Form
    {
        List<Game> games = new List<Game>
        {
         new Game{IdGame = 1, Name = "Tetris", Category = "головоломка", Price = 150},
         new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Category = "платформер", Price = 10},
         new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Category = "аркада", Price = 300},
         new Game{IdGame = 4, Name = "Arkanoid", Category = "аркада", Price = 400},
         new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Category = "платформер", Price = 1000},
        };

        List<Category> categories = new List<Category>
        {
         new Category{Name = "головоломка", Description = "описание жанра головоломка"},
         new Category{Name = "платформер", Description = "описание жанра платформер"},
         new Category{Name = "RPG", Description = "описание жанра RPG"},
         new Category{Name = "аркада", Description = "описание жанра аркада"}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = games.Select(game => new { game.Name, game.Price });
            gamesDataGridView.DataSource = result.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamesDataGridView.DataSource = games;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = games.Where(game => game.Category=="аркада").Where(game => game.Price == 400);
            gamesDataGridView.DataSource = result.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = games.OrderBy(game => game.Category).ThenByDescending(game=>game.Price);
            gamesDataGridView.DataSource = result.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var result = games.Skip(2).Take(2);
            gamesDataGridView.DataSource = result.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var result = games.Max(game => game.Price);
            MessageBox.Show(result.ToString());
        }
    }
}