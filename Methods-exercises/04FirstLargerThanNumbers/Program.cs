using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FirstLargerThanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            if(numArr.Length>3)
            {
                Console.WriteLine(GetIndexOfFirstLargerThanNumbers(numArr));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
        static int GetIndexOfFirstLargerThanNumbers(int[] numArr)
        {
            int toPrint = -1;
            for(int i =1; i<=numArr.Length-2; i++)
            {
                if(numArr[i]>numArr[i-1] && numArr[i]>numArr[i+1])
                {
                    toPrint = i;
                    break;
                }
            }

            return toPrint;
        }
    }
}
