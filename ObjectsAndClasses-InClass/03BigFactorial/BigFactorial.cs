using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _03BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger result = 2;
            for(int i = 3; i<=number; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}
