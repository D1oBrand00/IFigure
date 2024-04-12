using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntFigure
{
    class Triangle : IFigure
    {
        public string Name { get; set; }
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public Triangle() { }
        public Triangle(string name, int side1, int side2,int side3)
        {
            this.Name = name;
            this.Side1 = side1;
            this.Side2 = side2;
            this.Side3 = side3;
        }
        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
        public double Square()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
        public override string ToString()
        {
            return $"Название геометрической фигуры: {Name}\nПервая сторона: {Side1}\nВторая сторона: {Side2}\nТретья сторона: {Side3}\nПериметр: {Perimeter():F2}\nПлощадь: {Square():F2}\n";
        }
    }
}
