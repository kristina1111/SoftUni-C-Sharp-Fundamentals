using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DistanceBetweenPoints
{
    class DistanceBetweenPoints
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point p1 = new Point() { X=input[0], Y=input[1] };
            input = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Point p2 = new Point() { X = input[0], Y = input[1] };
            double result = GetDistanceBetweenPoints(p1, p2);

            Console.WriteLine("{0:f3}", result);
        }

        static double GetDistanceBetweenPoints(Point p1 , Point p2)
        {
            double distance = 0;
            double a = p1.X - p2.X;
            double b = p1.Y - p2.Y;
            distance = Math.Sqrt(a * a + b * b);
            return distance;
        }
    }
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
