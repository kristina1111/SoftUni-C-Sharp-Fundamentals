using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace E02ConvertFromAnyBaseTo10Base
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            BigInteger baseNum = BigInteger.Parse(input[0]);
            BigInteger numToConvert = BigInteger.Parse(input[1]);
            BigInteger result = 0;
            int cnt = 0;
            while (numToConvert != 0)
            {
                checked
                {
                    result += BigInteger.Pow(baseNum, cnt) * (numToConvert % 10);
                }
                numToConvert /= 10;
                cnt++;
            }
            Console.WriteLine(result);

        }
    }
}
