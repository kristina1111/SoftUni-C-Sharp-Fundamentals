﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LastDigitOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(GetLastDigitAsWord(input));
            }
        }
        static string GetLastDigitAsWord(int input)
        {
            int lastNum = input % 10;
            switch(lastNum)
            {
                case 1: return "one"; break;
                case 2: return "two"; break;
                case 3: return "three"; break;
                case 4: return "four"; break;
                case 5: return "five"; break;
                case 6: return "six"; break;
                case 7: return "seven"; break;
                case 8: return "eight"; break;
                case 9: return "nine"; break;
                case 0: return "zero"; break;
            }
            return "false";
        }
    }
}
