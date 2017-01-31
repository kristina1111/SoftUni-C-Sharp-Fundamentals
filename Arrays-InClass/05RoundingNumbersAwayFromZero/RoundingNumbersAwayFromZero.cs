using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main(string[] args)
        {
            double[] numArr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            for(int i =0; i<numArr.Length; i++)
            {
                Console.WriteLine("{0} => {1}", numArr[i], Math.Round(numArr[i], 0, MidpointRounding.AwayFromZero));
            }
        }
    }
}
