namespace Lection0201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter1 = new Counter { Value = 23 };
            Counter counter2 = new Counter { Value = 78 };

            Counter counter3 = counter1+ counter2;
            Console.WriteLine(counter3.Value);

            bool result = counter1 > counter2;
            Console.WriteLine(result);

        }
    }
}