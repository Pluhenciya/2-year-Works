namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> books = new List<string>();
            books.Add("Сказки");
            books.Add("Чарли Бон");
            books.Add("Гарри Поттер");

            Console.WriteLine("Введите количество книг");
            int nBook = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nBook; i++)
            {
                Console.WriteLine("Введите название книги");
                books.Add(Console.ReadLine());
            }

            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine($"№{i + 1} - {books[i]}");
            }
            Console.WriteLine($"Книг всего {books.Count}");

            Console.WriteLine("Введите букву");
            char userLetter = Convert.ToChar(Console.ReadLine());
            foreach (var book in books)
            {
                if (book[0] == userLetter)
                {
                    Console.WriteLine(book);
                }
            }

            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(8567, "Васильков Иван Аркадьевич");
            students.Add(8568, "Петрушенко Артём Витальевич");
            students.Add(8569, "Лолушенко Денис Артёмович");

            Console.WriteLine("Введите количество студентов");
            int nStud = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nStud; i++)
            {
                Console.WriteLine("Введите номер зачётки и ФИО студента");
                if (!students.TryAdd(Convert.ToInt32(Console.ReadLine()), Console.ReadLine()))
                {
                    Console.WriteLine("Такой номер зачётки существует в базе");
                    i--;
                }
            }

            PrintDictionary(students);

            Console.WriteLine("Введите номер зачетки");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            if (students.ContainsKey(userNumber))
            {
                Console.WriteLine($"Номер зачетки найден. Студент {students[userNumber]}");
            }
            else
            {
                Console.WriteLine("Номер зачетки не найден");
            }

            Console.WriteLine("Введите ФИО студента");
            string userName = Console.ReadLine();
            int counter = 0;
            foreach (var student in students)
            {
                if (student.Value == userName)
                    counter++;
            }
            Console.WriteLine($"Найдено {counter} совпадений");

            Console.WriteLine("Введите номер зачетки");
            userNumber = Convert.ToInt32(Console.ReadLine());
            if (students.ContainsKey(userNumber))
            {
                students.Remove(userNumber);
            }
            else
            {
                Console.WriteLine("Номер зачетки не найден");
            }
            PrintDictionary(students);
        }

        private static void PrintDictionary(Dictionary<int, string> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} - {student.Value}");
            }
            Console.WriteLine($"Студентов всего {students.Count}");
        }
    }
}