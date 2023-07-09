namespace Task2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var task1 = Task.Run(() => Power(2, 3));
            var task2 = Task.Run(() => Power(3, -2));
            var task3 = Task.Run(() => Power(4, 0));

            double[] results = await Task.WhenAll(task1, task2, task3);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(await FormulaAsync(new double[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 2 }));

        }

        static double Power(double a, int x)
        {
            double result = 1;
            for (int i = 1; i <= Math.Abs(x); i++)
                result *= a;
            if (x < 0)
                result = 1 / result;
            return result;
        }

        static async Task<double> FormulaAsync(double[] a, int[] x)
        {
            return (await Task.Run(() => Power(a[0], x[0])) + await Task.Run(() => Power(a[1], x[1]))) *
                (await Task.Run(() => Power(a[2], x[2])) - await Task.Run(() => Power(a[3], x[3])));
        }
    }
}