namespace Task2
{
    internal class Program
    {
        delegate void Function(int x, int y);

        static void Main(string[] args)
        {
            Function operation = (x, y) => Console.WriteLine(x + y);
            operation += (x, y) => Console.WriteLine(x - y);
            operation += (x, y) => Console.WriteLine(x * y);
            operation += (x, y) => Console.WriteLine(x / y);
            operation(6, 3);
        }
    }
}