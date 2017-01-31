using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < numArray.Length; i++)
            {
                int leftSum = GetLeftSum(numArray, i);
                int rightSum = GetRightSum(numArray, i);
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    break;
                }
                else if (i == numArray.Length - 1)
                {
                    Console.WriteLine("no");
                }
            }
        }
        static int GetLeftSum(int[] array, int position)
        {
            int leftSum = 0;
            for (int k = position - 1; k >= 0; k--)
            {
                leftSum += array[k];
            }
            return leftSum;
        }

        static int GetRightSum(int[] array, int position)
        {
            int rightSum = 0;
            for (int k = position + 1; k < array.Length; k++)
            {
                rightSum += array[k];
            }
            return rightSum;
        }
    }
}