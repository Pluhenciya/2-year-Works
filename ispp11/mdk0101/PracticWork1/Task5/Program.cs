using System.IO;

Console.WriteLine("Введите имя папки");
string directoryName = Console.ReadLine();
DirectoryInfo directory = new(directoryName);
FileInfo[] files = directory.GetFiles();
foreach (FileInfo file in files)
{
    DateTime date = file.CreationTime;
    string path = $"{directoryName}/{date.Year}/{date.Month}/{date.Day}";
    if (!Directory.Exists(path))
    {
		Directory.CreateDirectory(path);
    }
    file.MoveTo($"{path}/{file.Name}", true);
}


