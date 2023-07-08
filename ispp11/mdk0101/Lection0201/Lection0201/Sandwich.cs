namespace Lection0201
{
    internal class Bread
    {
        public int Weight { get; set; }
    }

    internal class Cheese
    {
        public int Weight { get; set; }
    }

    internal class Sandwitch
    {
        public int Weight { get; set; }

        public static Sandwitch operator +(Sandwitch sandwitch, Cheese cheese)
        {
            return new Sandwitch { Weight = sandwitch.Weight + cheese.Weight };
        }
        public static Sandwitch operator +(Sandwitch sandwitch, Bread bread)
        {
            return new Sandwitch { Weight = sandwitch.Weight + bread.Weight };
        }
    }
}
