using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                char[] charNums = Console.ReadLine().ToCharArray();
                int sumOdd = 0;
                int sumEven = 0;
                for (int i = 0; i < charNums.Length; i++)
                {
                    if (charNums[i] == '-' || charNums[i]=='.')
                    {
                        continue;
                    }

                    int number = int.Parse(charNums[i].ToString());
                    if (number % 2 == 1)
                    {
                        sumOdd += number;
                    }
                    else
                    {
                        sumEven += number;
                    }
                }
                Console.WriteLine((double)sumEven * sumOdd);
            }
        }
    }
}
