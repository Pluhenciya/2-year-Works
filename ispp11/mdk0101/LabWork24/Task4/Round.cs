namespace Task4
{
    internal class Round : Figure
    {
        public double radius;

        public override double GetSquare()
        {
            Console.WriteLine("Введите радиус");
            radius = Convert.ToInt32(Console.ReadLine());
            return GetSquareRound(radius);
        }
    }
}
