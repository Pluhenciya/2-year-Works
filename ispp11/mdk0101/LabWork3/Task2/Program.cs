Console.WriteLine("Введите сначала то число, которое хотите возвести в степень, потом степень");
double x = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(x, n));

static double Power(double x, int n)
{
    return n > 0 ? x * Power(x, n - 1) : n == 0 ? 1 : 1 / Power(x, -n);
}