namespace Task4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetSquareFigure("прямоугольник"));
            Console.WriteLine(GetSquareFigure("круг"));
            Console.WriteLine(GetSquareFigure("кольцо"));
        }

        static double GetSquareFigure(string typeFigure)
        {
            switch (typeFigure.ToLower())
            {
                case "прямоугольник":
                    Rectangle rectangle = new Rectangle();
                    return rectangle.GetSquare();
                case "круг":
                    Round round = new Round();
                    return round.GetSquare();
                case "кольцо":
                    Ring ring = new Ring();
                    return ring.GetSquare();
                default:
                    return -1;
            }

        }
    }
}