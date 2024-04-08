using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntFigure
{
    class Rectangle : IFigure
    {
        public double Square(int a, int b)
        {
            return a * b;
        }
        public double Perimeter(int a, int b)
        {
            return (a + b) * 2;
        }
    }
}
