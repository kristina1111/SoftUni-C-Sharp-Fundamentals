using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] mainArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sumArray = new int[mainArray.Length / 2];

            int[] leftArrayToSum = GetLeftArrayToSum(mainArray);
            int[] rightArrayToSum = GetRightArrayToSum(mainArray);
            for (int i = 0; i < sumArray.Length; i++)
            {
                if (i < sumArray.Length / 2)
                {
                    sumArray[i] = mainArray[mainArray.Length / 4 + i] + leftArrayToSum[i];
                }
                else
                {
                    sumArray[i] = mainArray[mainArray.Length / 4 + i] + rightArrayToSum[i - sumArray.Length / 2];
                }
                //sumArray[i] = mainArray[mainArray.Length / 4 + i] + (i < sumArray.Length / 2 ? leftArrayToSum[i] : rightArrayToSum[i - sumArray.Length / 2]);
            }
            Console.WriteLine(string.Join(" ", sumArray));

        }

        private static int[] GetRightArrayToSum(int[] inputArray)
        {
            int[] arrayToSum = new int[inputArray.Length / 4];
            for (int i = inputArray.Length - 1, k = 0; i >= inputArray.Length - inputArray.Length / 4; i--, k++)
            {
                arrayToSum[k] = inputArray[i];
            }
            return arrayToSum;
        }

        static int[] GetLeftArrayToSum(int[] inputArray)
        {
            int[] arrayToSum = new int[inputArray.Length / 4];
            for (int i = inputArray.Length / 4 - 1, k = 0; i >= 0; i--, k++)
            {
                arrayToSum[k] = inputArray[i];
            }
            return arrayToSum;
        }
    }
}
