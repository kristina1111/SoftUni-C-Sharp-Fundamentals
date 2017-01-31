using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Numerics;

namespace E08LettersChangeNumbers
{
    class LettersChangeNumbers
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = @"([A-Za-z])(\d+)([A-Za-z])";
            Regex rgx = new Regex(pattern);
            double totalSum = 0;
            double sumToPrint = 0;
            for(int i =0; i<input.Length; i++)
            {
                Match match = rgx.Match(input[i]);
                char leftChar = char.Parse(match.Groups[1].ToString());
                double num = double.Parse(match.Groups[2].ToString());
                char rightChar = char.Parse(match.Groups[3].ToString());
                if (leftChar>=65 &&leftChar<=90)
                {
                    totalSum += num / (double)(leftChar - 64);
                }
                else if(leftChar >= 97 && leftChar <= 122)
                {
                    totalSum += num * (double)(leftChar - 96);
                }

                if(rightChar >= 65 && rightChar <= 90)
                {
                    totalSum -= (double)(rightChar - 64);
                }
                else if(rightChar >= 97 && rightChar <= 122)
                {
                    totalSum += (double)(rightChar - 96);
                }
                sumToPrint += totalSum;
                totalSum = 0;
            }
            Console.WriteLine("{0:f2}", sumToPrint);
        }
    }
}
