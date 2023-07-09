using System.Text.RegularExpressions;

Regex regex = new(@"(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[.!?]).{6,}");
string userPassword;
do
{
    Console.WriteLine("Введите пароль");
    userPassword = Console.ReadLine();
    if (regex.IsMatch(userPassword))
    {
        Console.WriteLine("Вы зарегистрированы");
        break;
    }
    Console.WriteLine("Пароль введён некорректно");
} while (true);

