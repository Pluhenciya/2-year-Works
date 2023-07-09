namespace Task3
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            await WriteFileAsync(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Конец программы");
        }

        static async Task WriteFileAsync(string name, int n)
        {
            Console.WriteLine("Начало записи");
            Random random = new Random();
            string fileName = Path.Combine(Environment.CurrentDirectory, name);
            using (StreamWriter sw = new StreamWriter(fileName, false))
            {
                for (int i = 0; i < n; i++)
                {
                    string text = $"Число №{i + 1}: {random.NextInt64()}";
                    await sw.WriteLineAsync(text);
                }
            }
            Console.WriteLine("Конец записи");
        }
    }
}