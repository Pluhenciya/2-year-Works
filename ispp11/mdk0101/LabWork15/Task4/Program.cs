namespace Task4
{
    internal class Program
    {
        delegate int Function(int x);

        static void Main(string[] args)
        {
            Function[] operations = { x => x * x, Factorial, x => x >= 0 ? x : -x };
            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine(operations[i](12));
            }
        }

        public static int Factorial(int x) => x > 1 ? x * Factorial(x - 1) : x >= 0 ? 1 : -1;

    }
}