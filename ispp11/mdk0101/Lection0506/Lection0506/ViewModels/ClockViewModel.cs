using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lection0506.ViewModels
{
    internal class ClockViewModel : INotifyPropertyChanged
    {
        DateTime _dateTime;
        Timer _timer;

        public event PropertyChangedEventHandler? PropertyChanged;

        public DateTime DateTime
        {
            get => _dateTime;
            set
            {
                _dateTime = value;
                OnPropertyChanged();
            }
        }

        public ClockViewModel()
        {
            DateTime = DateTime.Now;

            _timer = new Timer(new TimerCallback(s => DateTime = DateTime.Now), null, TimeSpan.Zero, TimeSpan.FromSeconds(1));
        }

        private void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
