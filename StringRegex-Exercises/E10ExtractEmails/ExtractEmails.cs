using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E09MelrahShake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?:^|\s)([a-zA-Z0-9]+([\-_\.][a-zA-Z0-9]+)?@[a-zA-Z]+([\-_][a-zA-Z0-9]+)?(\.[a-zA-Z]+)+)";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(input);
            foreach(Match m in matches)
            {
                Console.WriteLine(m.ToString().Trim(' '));
                //Console.WriteLine(m.Groups[1]);
            }
        }
    }
}