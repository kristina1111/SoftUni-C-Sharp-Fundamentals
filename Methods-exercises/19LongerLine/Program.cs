using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double line1X1 = double.Parse(Console.ReadLine());
            double line1Y1 = double.Parse(Console.ReadLine());
            double line1X2 = double.Parse(Console.ReadLine());
            double line1Y2 = double.Parse(Console.ReadLine());
            double line1Lenght = GetLineLength(line1X1, line1Y1, line1X2, line1Y2);

            double line2X1 = double.Parse(Console.ReadLine());
            double line2Y1 = double.Parse(Console.ReadLine());
            double line2X2 = double.Parse(Console.ReadLine());
            double line2Y2 = double.Parse(Console.ReadLine());
            double line2Lenght = GetLineLength(line2X1, line2Y1, line2X2, line2Y2);

            if (line1Lenght >= line2Lenght)
            {
                FirstPrintClosestPoint(line1X1, line1Y1, line1X2, line1Y2);
            }
            else
            {
                FirstPrintClosestPoint(line2X1, line2Y1, line2X2, line2Y2);
            }
            
        }
        static double GetLineLength(double lineX1, double lineY1, double lineX2, double lineY2)
        {
            double x = Math.Abs(lineX1 - lineX2);
            double y = Math.Abs(lineY1 - lineY2);
            double distance = Math.Sqrt(x * x + y * y);
            return distance;
        }

        static void FirstPrintClosestPoint(double lineX1, double lineY1, double lineX2, double lineY2)
        {
            double distanceX = Math.Abs(lineX1) + Math.Abs(lineY1);
            double distanceY = Math.Abs(lineX2) + Math.Abs(lineY2);
            if (distanceX <= distanceY)
            {
                Console.WriteLine("({0}, {1})({2}, {3})", lineX1, lineY1, lineX2, lineY2);
            }
            else
            {
                Console.WriteLine("({0}, {1})({2}, {3})", lineX2, lineY2, lineX1, lineY1);
            }
        }
    }                                      
}                                    