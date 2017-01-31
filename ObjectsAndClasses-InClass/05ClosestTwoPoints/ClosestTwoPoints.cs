using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            int numPoints = int.Parse(Console.ReadLine());
            Point[] pointsArray = new Point[numPoints];
            for(int i =0; i<numPoints; i++)
            {
                double[] inputXY = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
                Point point = new Point() { X = inputXY[0], Y = inputXY[1] };
                pointsArray[i] = point;
            }

            Point[] closestPoints = new Point[2];
            double smallestDistance = double.MaxValue;
            for(int i=0; i<pointsArray.Length; i++)
            {
                for(int k =i+1; k<pointsArray.Length; k++)
                {
                    double distance = CalculetaDistBetweenTwoPoints(pointsArray[i], pointsArray[k]);
                    if(distance<smallestDistance)
                    {
                        smallestDistance = distance;
                        closestPoints[0] = pointsArray[i];
                        closestPoints[1] = pointsArray[k];
                    }
                }
            }
            Console.WriteLine("{0:f3}", smallestDistance);
            Console.WriteLine("({0}, {1})\n({2}, {3})", closestPoints[0].X, closestPoints[0].Y, closestPoints[1].X, closestPoints[1].Y);
            
        }
        static double CalculetaDistBetweenTwoPoints(Point p1, Point p2)
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
