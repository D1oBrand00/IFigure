using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle("Прямоугольник",3,5);
            Triangle trng1 = new Triangle("Треугольник", 4, 6, 3);
            Circle crc1 = new Circle("Окружность", 6);
            Console.WriteLine($"{rect1.ToString()}\n{trng1.ToString()}\n{crc1.ToString()}");
            Console.ReadKey();
        }
    }
}
