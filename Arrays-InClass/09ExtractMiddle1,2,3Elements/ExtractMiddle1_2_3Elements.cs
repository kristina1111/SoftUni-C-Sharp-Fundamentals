using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ExtractMiddle1_2_3Elements
{
    class ExtractMiddle1_2_3Elements
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int middle = numArr.Length / 2 - 1;
            Console.Write("{ ");
            for (int i = middle; i <= middle + (numArr.Length % 2 == 1 ? 2 : 1); i++)
            {
                if(numArr.Length == 1)
                {
                    Console.Write("{0}", numArr[0]);
                    break;
                }
                Console.Write("{0}{1}", numArr[i], i!= (middle + (numArr.Length % 2 == 1 ? 2 : 1)) ? ", ":"");
            }
            Console.WriteLine(" }");
        }
    }
}
