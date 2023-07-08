using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class User
    {
        public event EventHandler PropertyChanged;

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
                    PropertyChanged?.Invoke(this, EventArgs.Empty);
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
                    PropertyChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        } 
    }
}
