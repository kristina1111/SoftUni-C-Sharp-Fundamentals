using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _23Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFactorial = int.Parse(Console.ReadLine());
            string number = CalculateBigInteger(numFactorial);
            int numTrailingZeroes = CalculateTrailingZeroes(number);
            Console.WriteLine(numTrailingZeroes);
        }

        private static int CalculateTrailingZeroes(string number)
        {
            int numZeroes = 0;
            int lengthNumber = number.Length - 1;
            for (int i = lengthNumber; i >= 0; i--)
            {
                if (number[i] != '0')
                {
                    return numZeroes;
                }
                numZeroes++;
            }
            return numZeroes;
        }

        private static string CalculateBigInteger(int numFactorial)
        {
            BigInteger number = 1;
            for (int i = 1; i <= numFactorial; i++)
            {
                number *= i;
            }
            return number.ToString();
        }
    }
}