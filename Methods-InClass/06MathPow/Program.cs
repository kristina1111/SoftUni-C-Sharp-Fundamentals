using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _06MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            // Judge: 90/100

            checked
            {
                double num = double.Parse(Console.ReadLine());
                double pow = double.Parse(Console.ReadLine());
                //Console.WriteLine(Math.Pow(num, pow));  --> Judge 100/100
                if (pow == 0)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    Console.WriteLine(GetNumToPower(num, pow));
                }
            }
        }

        private static double GetNumToPower(double number, double power)
        {
            checked
            {
                double result = 1;
                for (int i = 1; i <= power; i++)
                {
                    result *= number;
                }
                return result;
            }
            
        }
    }
}
