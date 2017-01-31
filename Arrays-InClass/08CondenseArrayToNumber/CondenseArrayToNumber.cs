using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CondenseArrayToNumber
{
    class CondenseArrayToNumber
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int cnt = numArr.Length; cnt >= 1; cnt--)
            {
                for(int i = 1, k = 0; i<cnt; i++, k++)
                {
                    int sumNum = numArr[i] + numArr[k];
                    numArr[k] = sumNum;
                }
            }
            Console.WriteLine(numArr[0]);
        }
    }
}
