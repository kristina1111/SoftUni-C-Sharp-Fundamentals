using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintClosestPoint(x1, y1, x2, y2);

        }
        static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double distanceX = Math.Abs(x1) + Math.Abs(y1);
            double distanceY = Math.Abs(x2) + Math.Abs(y2);
            if(distanceX<=distanceY)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }

    }
}
