using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    internal class Circle
    {
        static public double GetLength(double r)
        {
            return 2*Math.PI*r;
        }
        static public double GetSquare(double r)
        {
            return r*r*Math.PI;
        }
        static public string GetCoordinates(double r,double x,double y)
        {
            if (( x<= r&& -x <= r)&& (y <=r && -y <= r))
            {
                return $"Точка ({x};{y})  принадлежит окружности";
            }
            else
                return $"Точка ({x};{y}) не принадлежит окружности";

        }

    }
}
