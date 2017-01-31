using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15SumReversedNumbers
{
    class SumReversedNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = new string(input.Reverse().ToArray());
            string[] numArray = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            long sum = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                sum += long.Parse(numArray[i]);
            }
            Console.WriteLine(sum);
            //vababa
        }
    }
}
