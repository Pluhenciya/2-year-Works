using System.Text.RegularExpressions;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string userText = Console.ReadLine();
            Regex regex = new(@"(?<day>[12]\d|3[01]|0?[1-9])\.(?<month>1[0-2]|0?[1-9])\.(?<year>\d{4}|\d{2})|
                (?<day>[12]\d|3[01]|0?[1-9])/(?<month>1[0-2]|0?[1-9])/(?<year>\d{4}|\d{2})");
            Console.WriteLine(regex.Replace(userText, @"${year}-${month}-${day}"));
        }
    }
}
