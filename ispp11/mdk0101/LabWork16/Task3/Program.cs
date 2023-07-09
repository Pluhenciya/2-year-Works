using Task1;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new();
            user1.PropertyChanged += User_PropertyChanged;
            user1.Login = "";
            user1.Login = "dsfghsdihk";
        }

        static void User_PropertyChanged(object? sender, InfoEventArgs e)
        {
            var user = (User)sender;
            if (e.TextError != null)
            {
                Console.WriteLine($"{e.DateChange}: у пользователя {user.Login} не изменено {e.NameProperty}.\nОшибка:{e.TextError}");
            }
            else
            {
                Console.WriteLine($"{e.DateChange}: у пользователя {user.Login} изменено {e.NameProperty}.");
            }
        }
    }
}