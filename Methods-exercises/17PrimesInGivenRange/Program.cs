using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong firstNum = ulong.Parse(Console.ReadLine());
            ulong secNum = ulong.Parse(Console.ReadLine());
            PrintPrimesInRange(firstNum, secNum);

        }
        static void PrintPrimesInRange(ulong start, ulong end)
        {
            string toPrint = "";
            if(start>end)
            {
                return;
            }

            if (start < 2 && end<2)
            {
                return;
            }

            for (ulong i = start; i <= end; i++)
            {
                bool isPrime = true;
                for(ulong divider = 2; divider<=Math.Sqrt(i); divider++)
                {
                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime && i!=0 && i!=1)
                {
                    toPrint = toPrint + i + ", ";
                }
                
            }
            toPrint = toPrint.TrimEnd(new char[] { ',', ' ' });
            Console.Write(toPrint);
            Console.WriteLine();
        }
    }
}
