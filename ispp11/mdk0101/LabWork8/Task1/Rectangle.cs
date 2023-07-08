namespace Task1
{
    internal class Rectangle : Figure
    {
        public double width;
        public double length;

        public override string Name { get => "Прямоугольник"; }

        public Rectangle(double width, double lenght)
        {
            this.width = width;
            this.length = lenght;
        }

        public override double GetSquare()
        {
            return width * length;
        }

        public override double GetPerimeter()
        {
            return (width + length) * 2;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name}:{width} {length}");
        }
    }
}
