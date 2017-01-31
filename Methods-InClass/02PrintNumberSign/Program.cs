using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrintNumberSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintSign(input);
        }

        private static void PrintSign(int input)
        {
            Console.Write("The number {0} is", input);
            if(input<0)
            {
                Console.WriteLine(" negative.");
            }
            else if(input>0)
            {
                Console.WriteLine(" positive.");
            }
            else
            {
                Console.WriteLine(" zero.");
            }
        }
    }
}
