
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine(GetDaysCount(13, 2020));
        }
        catch (Exception)
        {
            Console.WriteLine("Данные введены некоректно");
        }
    }
    private static int GetDaysCount(int month, int year)
    {
        if (month < 1 || month > 12)
            throw new ArgumentException();
        int[] MonthDays = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (month == 2)
        {
            bool isLeapYear = year % 400 == 0 || year % 100 != 0 && year % 4 == 0;
            if (isLeapYear)
                MonthDays[1] += 1;
        }
        return MonthDays[month - 1];

    }
}