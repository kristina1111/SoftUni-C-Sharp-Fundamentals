using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11RectangleProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideA = double.Parse(Console.ReadLine());
            double sideB = double.Parse(Console.ReadLine());
            double perimeter = sideA * 2 + sideB * 2;
            Console.WriteLine(perimeter);
            double area = sideB * sideA;
            Console.WriteLine(area);
            double diagonal = Math.Sqrt(sideA * sideA + sideB * sideB);
            Console.WriteLine(diagonal);

        }
    }
}
