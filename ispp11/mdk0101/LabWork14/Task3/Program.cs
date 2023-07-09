using System.Text.RegularExpressions;

Console.WriteLine("Введите адрес электронной почты");
string userEmail = Console.ReadLine();
Regex regex = new(@"^[a-z\d_-]+@([a-z\d]+\.)+[a-z]+$", RegexOptions.IgnoreCase);
if (regex.IsMatch(userEmail))
    Console.WriteLine("Электронная почта введена верно");
else
    Console.WriteLine("Электронная почта введена неверно");