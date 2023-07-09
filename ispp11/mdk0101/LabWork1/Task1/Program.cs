int[] numbers = new int[5];
int minIndex, temp;
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100); // случайное число от 0 до 100
}

OutputArray(numbers);

for (int i = 0; i < numbers.Length - 1; i++)//O(n)
{
    minIndex = i;
    for (int j = i + 1; j < numbers.Length; j++)//O(n)
    {
        if (numbers[j] < numbers[minIndex])
        {
            minIndex = j;
        }
    }
    if (minIndex != i)
    {
        temp = numbers[i];
        numbers[i] = numbers[minIndex];
        numbers[minIndex] = temp;
    }
}
//O(n^2)

OutputArray(numbers);

static void OutputArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " "); // Вывод массива

    }
    Console.WriteLine();
}



