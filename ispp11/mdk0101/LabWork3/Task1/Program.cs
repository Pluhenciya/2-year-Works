Console.WriteLine("Введите значение для вычисления его факториала");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(x));

static int Factorial(int x)
{
    return x < 0 ? -1 : x < 2 ? 1 : x * Factorial(x - 1);
}