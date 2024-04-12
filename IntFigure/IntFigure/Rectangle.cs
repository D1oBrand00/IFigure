using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntFigure
{
    class Rectangle : IFigure
    {
        public string Name { get; set; }
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public Rectangle() { }
        public Rectangle(string name, int side1, int side2)
        {
            this.Name = name;
            this.Side1 = side1;
            this.Side2 = side2;
        }
        public double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }
        public double Square()
        {
            return Side1 * Side2;
        }
        public override string ToString()
        {
            return $"Название геометрической фигуры: {Name}\nПервая сторона: {Side1}\nВторая сторона: {Side2}\nПериметр: {Perimeter():F2}\nПлощадь: {Square():F2}\n";
        }
    }
}
