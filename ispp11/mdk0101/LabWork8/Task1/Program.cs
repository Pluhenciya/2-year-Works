namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Карамыслин Виктор Андреевич", "ВПК", 3);
            Student student2 = new Student("Капустин Максимильян Аркадьевич", "КСК", 1);
            Console.WriteLine(student1);
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student1.Equals(student2));
            Rectangle rectangle = new(5, 4);
            Console.WriteLine(rectangle.GetSquare());
            Console.WriteLine(rectangle.GetPerimeter());
            rectangle.Print();
        }
    }
}