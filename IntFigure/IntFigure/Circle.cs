using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntFigure
{
    class Circle : IFigure
    {
        public string Name { get; set; }
        public int R { get; set; }
        public Circle() { }
        public Circle(string name, int r)
        {
            this.Name = name;
            this.R = r;
        }
        public double Perimeter()
        {
            return 2 * Math.PI * R;
        }
        public double Square()
        {
            
            return Math.PI * Math.Pow(R,2);
        }
        public override string ToString()
        {
            return $"Название геометрической фигуры: {Name}\nРадиус: {R}\nПериметр: {Perimeter():F2}\nПлощадь: {Square():F2}\n";
        }
    }
}
