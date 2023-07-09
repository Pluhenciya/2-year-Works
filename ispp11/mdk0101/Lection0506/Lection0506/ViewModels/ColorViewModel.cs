using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Lection0506.ViewModels
{
    internal class ColorViewModel : INotifyPropertyChanged
    {
        byte _red;
        byte _green;
        byte _blue;

        Color _color;

        public byte Red
        {
            get => _red;
            set
            {
                if (_red != value)
                    Color = Color.FromRgb(value, Green, Blue);
            }
        }
        public byte Green
        {
            get => _green;
            set
            {
                if (_red != value)
                    Color = Color.FromRgb(Red, value, Blue);
            }
        }
        public byte Blue
        {
            get => _blue;
            set
            {
                if (_red != value)
                    Color = Color.FromRgb(Red, Green, value);
            }
        }
        public Color Color
        {
            get => _color;
            set
            {
                _color = value;
                _red = _color.R;
                _green = _color.G;
                _blue = _color.B;

                OnPropertyChanged("Red");
                OnPropertyChanged("Green");
                OnPropertyChanged("Blue");
                OnPropertyChanged("HexColor");
                OnPropertyChanged();
            }
        }

        public string HexColor
        {
            get
            {
                return $"#{Red:x2}{Green:x2}{Blue:x2}";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
