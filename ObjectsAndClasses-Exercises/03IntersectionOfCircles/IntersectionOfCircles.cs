using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03IntersectionOfCircles
{
    class IntersectionOfCircles
    {
        static void Main(string[] args)
        {
            Circle[] Circles = new Circle[2];
            for (int i = 0; i <= 1; i++)
            {
                double[] inputNums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                Circles[i] = ReturnCircle(inputNums);
            }
            double distanceBetweenCenters = GetDistanceBetweenCenters(Circles[0], Circles[1]);
            if(Circles[0].CircleIntersects(Circles[1], distanceBetweenCenters))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            
        }
        static Circle ReturnCircle(double[] inputArray)
        {
            Circle circle = new Circle()
            {
                X = inputArray[0],
                Y = inputArray[1],
                Radius = inputArray[2],
            };
            return circle;
        }
        static double GetDistanceBetweenCenters(Circle c1, Circle c2)
        {
            double a = c1.X - c2.X;
            double b = c1.Y - c2.Y;
            double distance = Math.Sqrt(a * a + b * b);
            return distance;
        }
    }

    class Circle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; set; }

        public bool CircleIntersects(Circle c, double distanceBetweenCenters)
        {
            bool doesIntersect = distanceBetweenCenters <= (c.Radius + Radius);
            return doesIntersect;
        }
    }
}
