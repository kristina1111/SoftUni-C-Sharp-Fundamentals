using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace E01ConvertFromBase10ToAnyBase
{
    class ConvertFromBase10ToAnyBase
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            BigInteger inputNum = BigInteger.Parse(input[1]);
            int divider = int.Parse(input[0]);
            StringBuilder sb = new StringBuilder();
            while (inputNum !=0)
            {
                string num = (inputNum % divider).ToString();
                sb.Insert(0, num);
                inputNum = inputNum / divider;
            }
            string result = sb.ToString();
            Console.WriteLine(result);
        }
    }
}
