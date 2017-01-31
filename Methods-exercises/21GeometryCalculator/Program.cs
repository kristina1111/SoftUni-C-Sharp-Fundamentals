using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine().ToLower();
            double areaToPrint = 0;
            switch (figureType)
            {
                case "triangle":
                    double sideTriangle = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    areaToPrint = sideTriangle * height / 2;
                    break;
                case "square":
                    double sideSqare = double.Parse(Console.ReadLine());
                    areaToPrint = sideSqare * sideSqare;
                    break;
                case "rectangle":
                    double side1Rectangle = double.Parse(Console.ReadLine());
                    double side2Rectangle = double.Parse(Console.ReadLine());
                    areaToPrint = side1Rectangle * side2Rectangle;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    areaToPrint = Math.PI * radius * radius;
                    break;
            }
            Console.WriteLine("{0:f2}", areaToPrint);
        }
    }
}
