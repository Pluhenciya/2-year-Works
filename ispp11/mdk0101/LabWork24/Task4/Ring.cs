using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Ring : Figure
    {
        public double bigRadius;
        public double smallRadius;

        public override double GetSquare()
        {
            Console.WriteLine("Введите радиусы кольца");
            bigRadius = Convert.ToInt32(Console.ReadLine());
            smallRadius = Convert.ToInt32(Console.ReadLine());
            if (bigRadius < smallRadius)
                (bigRadius, smallRadius) = (smallRadius, bigRadius);
            return GetSquareRound(bigRadius)-GetSquareRound(smallRadius);
        }
    }
}
