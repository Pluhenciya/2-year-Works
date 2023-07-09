namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new("Панасюк Анастасия Владимировна", "КСК", 5);
            Student student2 = new("Петров Алексей Николаевич", "ИСПВ", 2);
            Square square1 = new(6);
            Square square2 = new(9);
            IPrinter[] printers = { student1, student2, square1, square2 };
            IPrinter printer1 = student1;
            IPrinter printer2 = square1;

            student1.Print();
            square1.Print();

            square1.GetInfo();

            printer1.Print();
            printer2.Print();

            for (int i = 0; i < printers.Length; i++)
            {
                printers[i].Print();
                if (printers[i] is IFigure)
                {
                    Square square = printers[i] as Square;
                    Console.WriteLine(square.Name);
                }
            }
        }
    }
}