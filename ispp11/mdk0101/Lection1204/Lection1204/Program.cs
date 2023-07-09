using System.Net.Security;

namespace Lection1204
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            source.CancelAfter(2);
            Console.WriteLine("Hello World");
            var task1 = WaitAsync();
            var task2 = Task.Run(() => ShowFactorial(6),source.Token );
            await Task.WhenAll(task1, task2);
            //await WaitAsync();
            ////await WriteFileAsync();
            //await Task.Run(() => ShowFactorial(6));
            var factorial = await Task.Run(() => GetFactorial(6));
            Console.WriteLine(factorial);
        }

        static async Task WriteFileAsync()
        {
            string text = "hello world";
            string fileName = Path.Combine(Environment.CurrentDirectory, "hello.txt");
            using (StreamWriter sw = new StreamWriter("hello.txt", false))
            {
                await sw.WriteLineAsync(text);
            }
        }

        static void ShowFactorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            Console.WriteLine($"{n}! = {result}");
        }

        static long GetFactorial(int n)
        {
            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        static async Task WaitAsync()
        {
            await Task.Delay(3000);
            Console.WriteLine("Спасибо за ожидание");
        }
    }
}