namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = { new("Сиров виктор Анатольеич", "ИСПП", 3), new("Петров  Иван Иваныч", "ИСПП", 2),
                new("Калинцев артём Олегович", "КСК", 4) };

            Student student = new("Сидоров Виктор Анатольеич", "ИСПВ", 10);
            Student copiedStudent1 = student.Clone() as Student;
            Student copiedStudent2 = student;
            student.Course = 57678;

            Array.Sort(students, new DescendingComparer());
            PrintArray(students);

            Console.WriteLine();

            Array.Sort(students, new StringComparer());
            PrintArray(students);

            Console.WriteLine("\nМассив");
            PrintArray(students);
            Array.Sort(students);
            Console.WriteLine("\nОтсортированный массив");
            PrintArray(students);
            Console.WriteLine();

            if (students[0].Equals(students[1]))
                Console.WriteLine("Объекты равны");
            else
                Console.WriteLine("Объекты не равны");

            Console.WriteLine($"Обычный студент: {copiedStudent2}\nКлон: {copiedStudent1}");

        }

        private static void PrintArray(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

    }
}