internal class Program
{
    private string _login;
    private string _password;

    private static void Main(string[] args)
    {
        Console.WriteLine("Введите логин");
        string _login = Console.ReadLine();
        Console.WriteLine("Введите пароль");
        string _password = Console.ReadLine();
        Console.WriteLine("Введите ещё раз пароль");
        string confirm = Console.ReadLine();
        if (IsCorrectUserData(_login, _password, confirm))
            Console.WriteLine("Вы зарегистрированы");
        else
            Console.WriteLine("Неверно введены данные");
    }

    public static bool IsCorrectUserData(string login, string password, string confirm)
    {
        bool isLoginCorrect = login != "";
        bool isPasswordCorrect = password != "";
        bool isConfirmCorrect = confirm == password;
        return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
    }
}