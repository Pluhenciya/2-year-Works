namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape redCircle = new RedShapeDecorator(new Circle());
            IShape blueRectangle = new BlueShapeDecorator(new Rectangle());

            Console.WriteLine("Circle with normal border");
            circle.Draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.Draw();

            Console.WriteLine("\nRectangle of blue border");
            blueRectangle.Draw();

            Console.WriteLine("\nCircle of blue and red border");
            circle = new RedShapeDecorator(circle);
            circle = new BlueShapeDecorator(circle);
            circle.Draw();
        }
    }
}