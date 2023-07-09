int[] numbers = new int[5];
int  temp;
Random random = new Random();
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(100); // случайное число от 0 до 100
}

OutputArray(numbers);

for (int i =  0; i < numbers.Length; i++)//O(n)
{
    for (int j = numbers.Length - 2; j >= i; j--)//O(n)
    {
        if (numbers[j] > numbers[j+1])
        {
            temp = numbers[j];
            numbers[j] = numbers[j + 1];
            numbers[j + 1] = temp;
        }
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