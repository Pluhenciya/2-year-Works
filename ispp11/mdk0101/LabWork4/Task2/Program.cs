﻿int n, m, x, y, d = 0, endX, endY;
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
    numbers[random.Next(0, numbers.GetLength(0)), random.Next(0, numbers.GetLength(1))] = -2;
}
endX = random.Next(0, numbers.GetLength(0));
endY = random.Next(0, numbers.GetLength(1));
numbers[endX, endY] = 99;
numbers[x, y] = 0;

OutputMap(numbers);
do
{

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] == d)
            {
                if (i + 1 != numbers.GetLength(0))
                    numbers[i + 1, j] = numbers[i + 1, j] == -1 || numbers[i + 1, j] == 99 ? d + 1 : numbers[i + 1, j];
                if (j - 1 != -1)
                    numbers[i, j - 1] = numbers[i, j - 1] == -1 || numbers[i, j - 1] == 99 ? d + 1 : numbers[i, j - 1];
                if (i - 1 != -1)
                    numbers[i - 1, j] = numbers[i - 1, j] == -1 || numbers[i - 1, j] == 99 ? d + 1 : numbers[i - 1, j];
                if (j + 1 != numbers.GetLength(1))
                    numbers[i, j + 1] = numbers[i, j + 1] == -1 || numbers[i, j + 1] == 99 ? d + 1 : numbers[i, j + 1];
            }

        }
    }
    d++;
} while ((numbers[endX, endY] == 99) && (d < m * n));

OutputMap(numbers);

static void OutputMap(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write("{0}\t", numbers[i, j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}