Console.WriteLine("Введите имя папки");
string directoryName = Console.ReadLine();
Console.WriteLine("Введите имя файла");
string fileName = Console.ReadLine();
DirectoryInfo directory = new(directoryName);
FileInfo[] files = 
    directory.GetFiles($"*{fileName}*", SearchOption.AllDirectories);
foreach (var file in files)
{
    Console.WriteLine($"{file.Name} {file.Length}");
}
