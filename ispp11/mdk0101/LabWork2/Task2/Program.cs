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
//Поиск значения. Сложность O(log(n)), т.к. массив делится на две части
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
    int i = numbers.Length;//чтобы выйти из зациклинности
    int middle = numbers.Length / 2; ;
    int left = 0, right = numbers.Length - 1;
    do
    {
        i--;
        middle = (right + left) / 2;
        if (value == numbers[middle])
            return middle;
        if (value < numbers[middle])
            right = middle - 1;
        else
            left = middle + 1;
    } while (right > left);
    return -1;//O(n)
}
