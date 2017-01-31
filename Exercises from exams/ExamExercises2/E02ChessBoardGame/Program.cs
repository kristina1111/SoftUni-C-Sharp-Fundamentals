using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02ChessBoardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            char[] inputArr = new char[n * n];
            for (int i = 0; i < (input.Length < inputArr.Length ? input.Length : inputArr.Length); i++)
            {
                inputArr[i] = input[i];
            }
            int sumBlack = 0;
            int sumWhite = 0;
            for (int i = 0; i < n * n; i++)
            {
                if (inputArr[i] >= 65 && inputArr[i] <= 90 || inputArr[i] >= 97 && inputArr[i] <= 122 || inputArr[i] >= 48 && inputArr[i] <= 57)
                {
                    if (i % 2 == 0)
                    {
                        if (inputArr[i] >= 65 && inputArr[i] <= 90)
                        {
                            sumWhite += inputArr[i];
                        }
                        else
                        {
                            sumBlack += inputArr[i];
                        }
                    }
                    else
                    {
                        if (inputArr[i] >= 65 && inputArr[i] <= 90)
                        {
                            sumBlack += inputArr[i];
                        }
                        else
                        {
                            sumWhite += inputArr[i];
                        }
                    }
                }
            }
            if(sumBlack!=sumWhite)
            {
                Console.WriteLine("The winner is: {0} team", sumBlack>sumWhite? "black":"white");
                Console.WriteLine("{0}", Math.Abs(sumWhite-sumBlack));
            }
            else
            {
                Console.WriteLine("Equal result: {0}", sumWhite);
            }
        }
    }
}
