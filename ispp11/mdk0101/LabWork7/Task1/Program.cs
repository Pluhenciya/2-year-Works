namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new("Петров Илья Васильевич", "ОИБ", 2);
            Student student2 = new("Сидоров Илья Николаевич", "ИСПП", 3);
            Console.WriteLine($"{student1.Name} {student1.Specialty} {student1.Course}");
            ++student1;
            Console.WriteLine($"{student1.Name} {student1.Specialty} {student1.Course}\n");

            Console.WriteLine($"{student2.Name} {student2.Specialty} {student2.Course}");
            Console.WriteLine($"{student1.Name} {student1.Specialty} {student1.Course}");
            Student student3 = student2 + student1;
            Console.WriteLine($"{student3.Name} {student3.Specialty} {student3.Course}");

            Console.WriteLine(student1 == student2);
            Console.WriteLine(student3 != student1);

            if (student1)
                Console.WriteLine("Данные коректны");
            else
                Console.WriteLine("Данные не коректны");
        }
    }
}