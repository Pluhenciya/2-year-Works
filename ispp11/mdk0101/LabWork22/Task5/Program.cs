namespace Task5
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CancellationTokenSource source= new CancellationTokenSource();
            source.CancelAfter(50);
            await ReadFileAsync("numbers.txt", source);
            await ReadFileAsync("numbers1.txt", source);
            await ReadFileAsync("numbers2.txt", source);
        }

        static async Task ReadFileAsync(string fileName, CancellationTokenSource source)
        {
            try
            {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = await sr.ReadLineAsync(source.Token)) != null)
                {
                    Console.WriteLine($"{fileName}:{line}");
                }
            }
            }
            catch (TaskCanceledException)
            {
                Console.WriteLine("Время ожидания привышено");
            }

        }
    }
}