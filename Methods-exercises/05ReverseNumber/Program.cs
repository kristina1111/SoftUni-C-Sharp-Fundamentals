using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputArr = input.ToCharArray();
            Console.WriteLine(GetReversedNumber(inputArr));

        }
        static double GetReversedNumber(char[] inputArr)
        {
            double reversedInput = default(double);
            Array.Reverse(inputArr);
            string input = new string(inputArr);
            reversedInput = double.Parse(input);
            return reversedInput;
        }
    }
}
