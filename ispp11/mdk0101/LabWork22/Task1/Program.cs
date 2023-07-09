namespace Task1
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var task1 = Task.Run(() => Power(2, 3));
            var task2 = Task.Run(() => Power(3, -2));
            var task3 = Task.Run(() => Power(4, 0));

            await Task.Run(() => Power(2, 3));
            await Task.Run(() => Power(3, -2));
            await Task.Run(() => Power(4, 0));

            await Task.WhenAll(task1, task2, task3);
        }

        static void Power(double a, int x)
        {
            double result = 1;
            for (int i = 1; i <= Math.Abs(x); i++)
                result *= a;
            if (x < 0)
                result = 1 / result;
            Console.WriteLine($"{a}^{x}={result}");
        }
    }
}