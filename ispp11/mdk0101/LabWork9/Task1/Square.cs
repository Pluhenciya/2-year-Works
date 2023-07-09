namespace Task1
{
    internal class Square : IPrinter, IFigure
    {
        public double Side { get; set; }

        public string Name { get => "Квадрат"; }

        public Square(double side)
        {
            Side = side;
        }

        public void Print()
        {
            Console.WriteLine($"Сторона {Side}");
        }

        public double GetSquare()
        {
            return Side * Side;
        }

        public double GetPerimeter()
        {
            return Side * 4;
        }

        public void GetInfo()
        {
            Console.WriteLine($"{Name} {GetSquare()} {GetPerimeter()} ");
        }
    }
}
