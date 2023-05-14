using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PW
{
    static class Rectangle
    {
        static public double GetSquare(double a, double b)
        {
            return a * b;
        }
        static public double GetPerimeter(double a, double b)
        {
            return 2*(a + b);
        }
    }
}
