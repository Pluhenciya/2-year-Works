using System.Text.RegularExpressions;

Console.WriteLine("Введите текст");
string userText = Console.ReadLine();
Regex regex = new(@"\s{2,}");
Console.WriteLine(regex.Replace(userText, " "));
