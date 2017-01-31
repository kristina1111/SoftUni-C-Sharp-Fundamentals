using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintUpperPartOfTriangle(input);
            PrintDownPartOfTriangle(input);
        }

        private static void PrintUpperPartOfTriangle(int input)
        {
            for(int row=1; row <= input; row++)
            {
                for(int col = 1; col<=row; col++)
                {
                    Console.Write("{0}{1}", col, col==input ? "" : " ");
                }
                Console.WriteLine();
            }
        }

        private static void PrintDownPartOfTriangle(int input)
        {
            for (int row = input - 1; row >= 1; row--)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write("{0}{1}", col, col == input ? "" : " ");
                }
                Console.WriteLine();
            }
        }
    }
}
