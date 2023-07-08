using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal abstract class Figure
    {
        public abstract double GetSquare();

        public double GetSquareRound(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
