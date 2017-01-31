using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E13ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=^| |\/|\\|\)|\(|\t|\n)([a-zA-Z][\w]{2,25})(?= |\/|\\|\)|\(|\t|\n|$)";
            Regex rgx = new Regex(pattern, RegexOptions.Multiline);
            MatchCollection matches = rgx.Matches(input);
            string[] arrayValidUsernames = matches.OfType<Match>().Select(m => m.Groups[1].Value).ToArray();
            string[] usernamesWithLongestSumLength = new string[2];
            int maxLength = 0;
            for(int i =1; i<arrayValidUsernames.Length; i++)
            {
                if(arrayValidUsernames[i].Length+arrayValidUsernames[i-1].Length>maxLength)
                {
                    usernamesWithLongestSumLength[0] = arrayValidUsernames[i - 1];
                    usernamesWithLongestSumLength[1] = arrayValidUsernames[i];
                    maxLength = arrayValidUsernames[i].Length + arrayValidUsernames[i - 1].Length;
                }
            }
            Console.WriteLine(usernamesWithLongestSumLength[0]);
            Console.WriteLine(usernamesWithLongestSumLength[1]);
        }
    }
}
