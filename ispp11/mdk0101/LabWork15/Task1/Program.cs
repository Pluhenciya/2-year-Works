namespace Task1
{
    internal class Program
    {
        delegate int Function(int x);

        static void Main(string[] args)
        {
            Function operation = x => x * x;
            Console.WriteLine(operation(12));
            operation = x => x > 1 ? x * operation(x - 1) : x >= 0 ? 1 : -1;
            Console.WriteLine(operation(5));
            operation = x => x >= 0 ? x : -x;
            Console.WriteLine(operation(-5));
        }
    }
}