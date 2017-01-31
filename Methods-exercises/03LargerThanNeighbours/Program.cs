using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for(int pstn = 0; pstn<numArr.Length; pstn++)
            {
                Console.WriteLine(IsLargerThanNeighbours(numArr, pstn));
            }
        }
        static bool IsLargerThanNeighbours(int[] numArr, int pstn)
        {
            if (pstn == 0)
            {
                if (numArr[pstn] > numArr[pstn + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (pstn == (numArr.Length - 1))
            {
                if (numArr[pstn] > numArr[pstn - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (numArr[pstn] > numArr[pstn - 1] && numArr[pstn] > numArr[pstn + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
