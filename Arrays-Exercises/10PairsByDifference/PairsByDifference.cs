using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PairsByDifference
{
    class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            int cnt = 0;
            for (int num = 0; num < numArray.Length; num++)
            {
                for (int i = num + 1; i < numArray.Length; i++)
                {
                    if (Math.Abs(numArray[num] - numArray[i]) == diff)
                    {
                        cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
