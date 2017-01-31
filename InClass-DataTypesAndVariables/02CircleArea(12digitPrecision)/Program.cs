using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02CircleArea_12digitPrecision_
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double crclArea = radius * radius * Math.PI;
            Console.WriteLine("{0:f12}", crclArea);
        }
    }
}
