using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideLength = double.Parse(Console.ReadLine());
            double toPrint = CalculateWhatNeeded(sideLength);
            Console.WriteLine("{0:f2}", toPrint);
        }

        private static double CalculateWhatNeeded(double sideLength)
        {
            string toCalculate = Console.ReadLine().ToLower();
            switch (toCalculate)
            {
                case "face":
                    return Math.Sqrt(2 * sideLength * sideLength);
                    break;
                case "space":
                    return Math.Sqrt(3 * sideLength * sideLength);
                    break;
                case "volume":
                    return sideLength * sideLength * sideLength;
                    break;
                case "area":
                    return 6 * sideLength * sideLength;
                    break;
            }
            return 0;
        }
    }
}
