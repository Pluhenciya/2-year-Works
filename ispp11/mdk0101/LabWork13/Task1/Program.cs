using System.Text;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст");
            string userString = Console.ReadLine();
            Console.WriteLine($"Количество символов: {userString.Length}");
            Console.WriteLine($"Количество символов без пробелов:{userString.Replace(" ", "").Length}");
            int counter = 0;
            for (int i = 0; i < userString.Length; i++)
            {
                if (Char.IsLetter(userString[i]))
                {
                    counter++;
                }
            }
            Console.WriteLine($"Количество букв:{counter}");
            Console.WriteLine("Введите символ который хотите найти");
            char userChar = Convert.ToChar(Console.ReadLine());
            List<int> indexFoundChar = new List<int>();
            for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] == userChar)
                    indexFoundChar.Add(i);
            }
            Console.Write("Позиции найденных символов: ");
            if (indexFoundChar.Count == 0)
                Console.WriteLine("Символ не найден");
            foreach (var item in indexFoundChar)
            {
                Console.Write($"{item} ");
            }

            userString = String.Join(' ', userString.Split(' ', StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine("\nКакой регистр хотите?\n1.Верхний\n2.Нижний\n3.Инвертированный");
            byte userChoice = Convert.ToByte(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine(userString.ToUpper());
                    break;
                case 2:
                    Console.WriteLine(userString.ToLower());
                    break;
                case 3:
                    StringBuilder userStringBuilder = new(userString);
                    for (int i = 0; i < userStringBuilder.Length; i++)
                    {
                        if (Char.IsLower(userStringBuilder[i]))
                        {
                            userStringBuilder[i] = Char.ToUpper(userStringBuilder[i]);
                        }
                        else
                        {
                            userStringBuilder[i] = Char.ToLower(userStringBuilder[i]);
                        }
                    }
                    Console.WriteLine(userStringBuilder.ToString());
                    break;
                default:
                    Console.WriteLine("Неверно введен номер");
                    break;
            }

            Console.WriteLine("Введите текст");
            string userText = Console.ReadLine();

            string[] results = userText.Split(new char[] { '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            Product product = new Product { Name = "Молоко", Price = 70.5, ExpirationDate = new DateTime(2023, 3, 12) };
            Console.WriteLine(product);

            string[] ourText = { "Шла Саша по шоссе", "Корабли лавировали", "Аты-баты" };
            Console.WriteLine("Введите текст");
            string userTextStart = Console.ReadLine();
            bool isNotFound = true;
            foreach (var item in ourText)
            {
                if (item.StartsWith(userTextStart))
                {
                    Console.WriteLine(item);
                    isNotFound= false;
                }
            }
            if (isNotFound)
            {
                Console.WriteLine("Не найдено");
            }
        }
    }
}