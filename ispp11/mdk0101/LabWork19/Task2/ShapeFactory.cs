namespace Task2
{
    internal class ShapeFactory
    {
        public IShape GetShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.ToLower().Equals("circle"))
            {
                return new Circle();
            }
            if (shapeType.ToLower().Equals("rectangle"))
            {
                return new Rectangle();
            }
            if (shapeType.ToLower().Equals("square"))
            {
                return new Square();
            }
            if (shapeType.ToLower().Equals("triangle"))
            {
                return new Triangle();
            }

            return null;
        }
    }
}
