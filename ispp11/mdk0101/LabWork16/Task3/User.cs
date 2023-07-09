using Task3;

namespace Task1
{
    internal class User
    {
        public event EventHandler<InfoEventArgs> PropertyChanged;

        string login;
        string password;

        public string Login
        {
            get => login;
            set
            {
                if (login != value)
                {
                    if (value == "")
                    {
                        PropertyChanged?.Invoke(this, new InfoEventArgs { NameProperty = "Логин", TextError = "Пустая строка", DateChange = DateTime.Now });
                    }
                    else
                    {
                        login = value;
                        PropertyChanged?.Invoke(this, new InfoEventArgs { NameProperty = "Логин", TextError = null, DateChange = DateTime.Now });
                    }

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
                    if (password.Length < 6 || password.Length > 20)
                    {
                        PropertyChanged?.Invoke(this, new InfoEventArgs { NameProperty = "Пароль", TextError = "Пароль не должен быть меньше 6 или более 20 символов", DateChange = DateTime.Now });
                    }
                    else
                    {
                        password = value;
                        PropertyChanged?.Invoke(this, new InfoEventArgs { NameProperty = "Пароль", TextError = null, DateChange = DateTime.Now });
                    }
                }
            }
        }
    }
}
