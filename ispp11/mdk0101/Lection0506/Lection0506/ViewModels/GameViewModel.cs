using Lection0506.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Lection0506.ViewModels
{
   internal class GameViewModel : ViewModelBase
    {
        Game _selectedGame;

        public GameViewModel(Game selectedGame)
        {
            SelectedGame = selectedGame;
        }

        public GameViewModel()
        {
        }

        public Game SelectedGame
        {
            get => _selectedGame;
            set
            {
                _selectedGame = value;
                OnPropertyChanged();
            }
        }
    }
}
