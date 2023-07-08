
Console.WriteLine("Введите количество байт");
int bytes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(GetSize(bytes));

string GetSize(int bytes)
{
    if (bytes >> 30 >= 1)
        return $"{bytes >> 30} ГБ";
    if (bytes >> 20 >= 1)
        return $"{bytes >> 20} MБ";
    if (bytes >> 10 >= 1)
        return $"{bytes >> 10} KБ";
    return $"{bytes} Б";
}