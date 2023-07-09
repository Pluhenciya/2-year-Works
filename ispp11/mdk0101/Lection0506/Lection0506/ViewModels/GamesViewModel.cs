using Lection0506.Models;
using Lection0506.Views;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace Lection0506.ViewModels
{
    internal class GamesViewModel : ViewModelBase
    {
        public ObservableCollection<Game> Games { get; set; }

        public ICollectionView CollectionView =>
            CollectionViewSource.GetDefaultView(SelectedGame);

        public Game SelectedGame
        {
            get => _selectedGame;
            set
            {
                _selectedGame = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand AddCommand
        {
            get => _addCommand ?? (_addCommand = new RelayCommand(obj =>
                        {
                            Game game = new Game();
                            game.IdGame = Games.Count() == 0 ? 1 : Games.Max(g=>g.IdGame+1);
                            game.Name = $"game {game.IdGame}";
                            Games.Add(game);
                            SelectedGame = game;
                        }
                ));
        }
        public RelayCommand RemoveCommand
        {
            get => _removeCommand ?? (_removeCommand = new RelayCommand(obj =>
                        {
                            if(obj is Game game && game != null) 
                            Games.Remove(game);
                        }, (obj => SelectedGame != null && Games.Count > 0)
                ));
        }

        public RelayCommand EditCommand
        {
            get => _editCommand ?? (_editCommand = new RelayCommand(obj =>
            {
                if (obj is Game game && game != null)
                {
                    GameWindow window = new GameWindow(game);
                    window.Show();
                }
            }, (obj => SelectedGame != null)
                ));
        }

        public GamesViewModel()
        {
            List<Game> gamesList = new List<Game>
            {
                 new Game{IdGame = 1, Name = "Tetris", Price = 150},
                 new Game{IdGame = 2, Name = "Flappy Bird", Description = "игра про летучую птицу", Price = 10},
                 new Game{IdGame = 3, Name = "Pac-man", Description = "игра про колобка", Price = 300},
                 new Game{IdGame = 4, Name = "Arkanoid", Price = 400},
                 new Game{IdGame = 5, Name = "Mario", Description = "игра про Марио", Price = 1000},
                 new Game{IdGame = 6, Name = "Tetris2", Price = 150},
                 new Game{IdGame = 7, Name = "Flappy Bird2", Description = "игра про летучую птицу", Price = 10},
                 new Game{IdGame = 8, Name = "Pac-man2", Description = "игра про колобка", Price = 300},
                 new Game{IdGame = 9, Name = "Arkanoid2", Price = 400},
                 new Game{IdGame = 10, Name = "Mario2", Description = "игра про Марио", Price = 1000},
            };

            Games = new ObservableCollection<Game>(gamesList);
        }

        Game _selectedGame;

        RelayCommand _editCommand;
        RelayCommand _addCommand;
        RelayCommand _removeCommand;
    }
}
