using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numArrMain = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int numRounds = int.Parse(Console.ReadLine());
            int[] sumArr = new int[numArrMain.Length];
            for (int i = 0; i < numRounds; i++)
            {
                int[] numArrToSum = GetArrayToBeSummed(numArrMain);

                sumArr = CalculateSumArray(sumArr, numArrToSum);

                numArrMain = numArrToSum;
            }
            Console.WriteLine(string.Join(" ", sumArr));
        }

        static int[] GetArrayToBeSummed(int[] arrayToRotate)
        {
            int toSaveNum = arrayToRotate[arrayToRotate.Length - 1];

            for (int k = arrayToRotate.Length - 1; k >= 1; k--)
            {
                arrayToRotate[k] = arrayToRotate[k - 1];
            }
            arrayToRotate[0] = toSaveNum;

            return arrayToRotate;
        }

        static int[] CalculateSumArray(int[] sumArray, int[] rotatedArray)
        {
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] += rotatedArray[i];
            }
            return sumArray;
        }
    }
}
