using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal interface IFigure
    {
        double GetSquare();

        double GetPerimeter();

        void GetInfo();

        string Name { get => "Фигура"; }
    }
}
