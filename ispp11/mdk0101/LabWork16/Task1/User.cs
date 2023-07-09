using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        string login;
        string password;

        public string Login
        {
            get => login; 
            set
            {                
                if (login != value)
                {
                    login = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public string Password
        {
            get => password; 
            set
            {
                if (password != value)
                {
                    password = value;
                    NotifyPropertyChanged();
                }
            }
        }


        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "") 
        { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
