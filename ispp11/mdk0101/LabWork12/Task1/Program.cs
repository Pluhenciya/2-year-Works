namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();

            Student student1 = new Student();
            Student student2 = new Student("Петров Артём Олегович", "ИСПП", 3);
            student2.Course = -100;
            student1.Course = 6;

            student1.Print();
            student2.Print();

            Console.WriteLine("Введите количество студентов");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[n];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            }
            students[random.Next(0, students.Length)].Level = EducationLevel.Master;
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Print();
            }

            Console.WriteLine();

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Level == EducationLevel.Master)
                    students[i].Print();
            }
   
            Entrant entrant1 = new();
            Entrant entrant2 = new();
            Entrant entrant3 = new("Зубенко Михаил Петрович", 9, 3.6);

            Console.WriteLine(entrant1);
            Console.WriteLine(entrant2);
            Console.WriteLine(entrant3);
            Console.WriteLine();
            OurEquals(entrant1, entrant2);
            OurEquals(entrant1, entrant3);
            OurEquality(entrant1, entrant2);
            OurEquality(entrant1, entrant3);

        }

        private static void OurEquality(Entrant entrant1, Entrant entrant2)
        {
            if (entrant1 == entrant2)
            {
                Console.WriteLine("Одинаковы");
            }
            else
            {
                Console.WriteLine("Не одинаковы");
            }
        }

        private static void OurEquals(Entrant entrant1, Entrant entrant2)
        {
            if (entrant1.Equals(entrant2))
            {
                Console.WriteLine("Одинаковы");
            }
            else
            {
                Console.WriteLine("Не одинаковы");
            }
        }
    }
}