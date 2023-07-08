int[] numbers = new int[5];
int value;

Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100); // случайное число от 0 до 100
}
Array.Sort(numbers);

OutputArray(numbers);
//Запрос значения
Console.WriteLine("Введите запрос:");
value = Convert.ToInt32(Console.ReadLine());
//Поиск значения. Сложность O(n)
Console.WriteLine(SearchIndex(numbers, value));

static void OutputArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " "); // Вывод массива

    }
    Console.WriteLine();
}

static int SearchIndex(int[] numbers, int value)
{
    int lastJumpStep = 0, jumpStep = Convert.ToInt32(Math.Sqrt(numbers.Length));
    for (int i = 0; i < numbers.Length; i += jumpStep)//O(n)
    {
        if (numbers[i] >= value)
        {
            for (int j = 0; j < numbers.Length; j++)//O(n)
            {
                if (numbers[j] == value)
                {
                    return j;
                }
            }
        }
        else
        {
            lastJumpStep = i;
        }
    }
    return -1;
}
