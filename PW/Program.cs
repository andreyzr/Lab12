using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a=Convert.ToDouble(Console.ReadLine());
            double b=Convert.ToDouble(Console.ReadLine());
            double square=Rectangle.GetSquare(a, b);
            double perimeter=Rectangle.GetPerimeter(a, b);
            Console.WriteLine($"{square} \n{perimeter}");
            Console.ReadKey();
        }
    }
}
