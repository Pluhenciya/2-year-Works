int[] numbers = new int[5];
int indexCompValue1, compValue2;
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100); // случайное число от 0 до 100
}

OutputArray(numbers);

//Сортировка массива
for (int i = 1; i < numbers.Length; i++)//O(n)
{
    compValue2 = numbers[i];
    indexCompValue1 = i-1;
    while ( indexCompValue1 >= 0 && compValue2 < numbers[indexCompValue1])//O(n)
    {
        numbers[indexCompValue1+1] = numbers[indexCompValue1];
        indexCompValue1--;
    }
    numbers[indexCompValue1+1] = compValue2;
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