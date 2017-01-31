using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LastKNumbersSum
{
    class LastKNumbersSum
    {
        static void Main(string[] args)
        {
            checked
            {
                long[] numArr = new long[int.Parse(Console.ReadLine())];
                if(numArr.Length!=0)
                {
                    numArr[0] = 1;
                    int secToSum = int.Parse(Console.ReadLine());
                    Console.Write("{0} ", numArr[0]);
                    for (int i = 1; i < numArr.Length; i++)
                    {
                        for (int k = i - 1; k >= Math.Max(i - secToSum, 0); k--)
                        {
                            numArr[i] += numArr[k];
                        }
                        Console.Write("{0}{1}", numArr[i], i != numArr.Length - 1 ? " " : "");
                    }
                }
            }
        }
    }
}
