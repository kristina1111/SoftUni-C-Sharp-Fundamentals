using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T03RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"([\D]+)([\d]+)";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();
            foreach (Match m in matches)
            {
                int rpte = int.Parse(m.Groups[2].ToString());
                string toAdd = m.Groups[1].ToString();
                for(int i =1; i<=rpte; i++)
                {
                    sb.Append(toAdd);
                }
            }
            string output = sb.ToString();
            string distinctChars = new string(output.Distinct().ToArray());
            int numchars = distinctChars.Length;
            Console.WriteLine("Unique symbols used: {0}", numchars);
            Console.WriteLine(output);
        }
    }
}
