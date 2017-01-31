using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14NumbersInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNumArr = Console.ReadLine();
            PrintReverseNum(inputNumArr);
        }

        static void PrintReverseNum(string input)
        {
            for(int i = input.Length-1; i>=0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
