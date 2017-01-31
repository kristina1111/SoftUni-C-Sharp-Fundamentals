using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double constEps = 0.000001;
            double numA = double.Parse(Console.ReadLine());
            double numB = double.Parse(Console.ReadLine());
            if(Math.Abs(numA-numB)<constEps)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
