Console.WriteLine("Введите имя файла");
string fileName = Console.ReadLine();
Console.WriteLine("Введите текст");
string text = Console.ReadLine();
if (File.Exists(fileName))
{
    string[] lines = File.ReadAllLines(fileName);
    for (int i = 0; i < lines.Length; i++)
    {
        if (lines[i].Contains(text))
        {
            Console.WriteLine($"{i + 1} {lines[i]}");
        }
    }
}
else
{
    Console.WriteLine("Этого файла не существует");
}
