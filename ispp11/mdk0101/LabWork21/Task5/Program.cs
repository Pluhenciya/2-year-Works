Console.WriteLine("Введите сначала то число, которое хотите возвести в степень, потом степень");
double x = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(x, n));

static double Power(double x, int n)
{
    if (n < 0)
        return -1;
    if (n == 0)
        return 1;
    if (n % 2 == 0)
        return Power(x * x, n / 2);
    return x * Power(x * x, n / 2);
}