using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13EnglishNameOfLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int lastDigit = int.Parse(input[input.Length - 1].ToString());
            Console.WriteLine(GetNameOfDigit(lastDigit));

        }
        static string GetNameOfDigit(int digit)
        {
            string name = "not Valid";
            switch (digit)
            {
                case 0: name = "zero"; break;
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
            }
            return name;
        }
    }
}
