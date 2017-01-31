using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            int[] numArr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numArr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] resultNumArr = new int[Math.Max(numArr1.Length, numArr2.Length)];

            for (int i = 0; i < resultNumArr.Length; i++)
            {
                resultNumArr[i] = numArr1[i % numArr1.Length] + numArr2[i % numArr2.Length];
                Console.Write("{0}{1}", resultNumArr[i], i!=resultNumArr.Length-1 ? " ":"\n");
            }
        }
    }
}
