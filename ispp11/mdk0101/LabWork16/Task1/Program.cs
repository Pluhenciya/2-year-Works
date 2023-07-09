using System.ComponentModel;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new();
            user1.PropertyChanged += User_PropertyChanged;
            user1.Login = "sjkgfgsj";
            user1.Login = "dsfghsdihk";
        }

        static void User_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            var user = (User)sender;
            Console.WriteLine($"Данные {e.PropertyName} изменены");
        }
    }
}