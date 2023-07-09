using System.Text.RegularExpressions;

Console.WriteLine("Введите номер телефона");
string userNumber = Console.ReadLine();
Regex regex = new(@"^((\+7)|8)\(9\d{2}\)\d{3}\-\d{2}\-\d{2}$");
if (regex.IsMatch(userNumber))
    Console.WriteLine("Номер введён верно");
else
    Console.WriteLine("Номер введён неверно");
