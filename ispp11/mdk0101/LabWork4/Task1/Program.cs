int n, m, x, y;
Console.WriteLine("Введите количество строк и столбцов:");
n = Convert.ToInt32(Console.ReadLine());
m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты начала (x,y)");
y = Convert.ToInt32(Console.ReadLine());
x = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[m, n];

Random random = new Random();

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = -1;
    }
}
for (int i = 0; i < numbers.GetLength(0); i++)
{
    numbers[random.Next(numbers.GetLength(0)), random.Next(numbers.GetLength(1))] = -2;
}
numbers[random.Next(numbers.GetLength(0)), random.Next(numbers.GetLength(1))] = 99;
numbers[x, y] = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.Write("{0}\t", numbers[i, j]);
    }
    Console.WriteLine();
}