using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Rectangle : Figure
    {
        public double width;
        public double length;

        public override double GetSquare()
        {
            Console.WriteLine("Введите ширину");
            width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину");
            length = Convert.ToInt32(Console.ReadLine());
            return width * length;
        }
    }
}
