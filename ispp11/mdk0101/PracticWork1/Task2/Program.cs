Console.WriteLine("Введите имя файла");
string fileName = Console.ReadLine();
if (File.Exists(fileName))
{
    Console.WriteLine("Файл открыт на дозапись");
}
else
{
    Console.WriteLine("Этого файла не существует. Будет создан новый.");
}
string text = "";
while (text != "end")
{
    File.AppendAllText(fileName, text);
    text = Console.ReadLine();
}