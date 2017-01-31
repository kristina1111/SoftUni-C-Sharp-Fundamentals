using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04TrippleSum
{
    class TrippleSum
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int cnt = 0;
            for(int i =0; i<numArr.Length; i++)
            {
                int a = numArr[i];
                for(int k = i+1; k<numArr.Length; k++)
                {
                    if(numArr.Contains(a+numArr[k]))
                    {
                        Console.WriteLine("{0} + {1} == {2}", a, numArr[k], a+numArr[k]);
                        cnt++;
                    }
                }
            }
            if(cnt == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
