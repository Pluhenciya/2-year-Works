namespace Task4
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await ReadFileAsync("numbers.txt");
            await ReadFileAsync("numbers1.txt");
            await ReadFileAsync("numbers2.txt");
        }

        static async Task ReadFileAsync(string fileName)
        {
            Console.WriteLine("Начало чтение");
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = await sr.ReadLineAsync()) != null) 
                {
                    Console.WriteLine($"{fileName}:{line}");
                }
            }
            Console.WriteLine("Конец чтение");
        }
    }
}