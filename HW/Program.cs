using Lab12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координатиу x точки :");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координатиу y точки :");
            double y = Convert.ToDouble(Console.ReadLine());
            double square = Circle.GetSquare(r);
            double length = Circle.GetLength(r);
            string coordinates = Circle.GetCoordinates(r,x,y);
            Console.WriteLine($"Площадь окружности равна:{square:f2} \nДлинна окружностиравна:{length:f2} \n{coordinates}");
            Console.ReadKey();
        }
    }
}
