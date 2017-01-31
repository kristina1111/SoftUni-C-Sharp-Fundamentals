using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double triangleBase = double.Parse(Console.ReadLine());
            double triangleHeight = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculateTriangleArea(triangleBase, triangleHeight));
        }

        private static double CalculateTriangleArea(double triangleBase, double triangleHeight)
        {
            double TriangleArea = triangleBase * triangleHeight/2;
            return TriangleArea;
        }
    }
}
