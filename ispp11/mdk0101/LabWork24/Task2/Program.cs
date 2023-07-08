using System.Reflection.Metadata;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();
            Console.WriteLine("Введите ещё раз пароль");
            string confirm = Console.ReadLine();
            User user = new(login, password);
            if(user.IsCorrectUserData(confirm))
                Console.WriteLine("Вы зарегистрированы");
            else
                Console.WriteLine("Неверно введены данные");
        }
    }
}