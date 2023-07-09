int[] numbers = new int[5];
int value;
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100); // случайное число от 0 до 100
}

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
    for (int i = 0; i < numbers.Length; i++)//O(n)
    {
        if (numbers[i] == value)
        {
            return i;
        }
    }
    return -1;
}