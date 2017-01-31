using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E09MelrahShake
{
    class MelrahShake
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = Console.ReadLine();
            string pattern2 = pattern;
            int cnt = 0;
            while (cnt < pattern.Length)
            {
                if (pattern[cnt] == '.' || pattern[cnt] == '\\' || pattern[cnt] == ')' || pattern[cnt] == '(')
                {
                    pattern = pattern.Insert(cnt, "\\");
                    cnt++;
                }
                cnt++;
            }

            while (true)
            {
                Regex rgx = new Regex("(" + pattern + ")");
                if (Regex.Matches(input, pattern).Count > 1)
                {
                    input = rgx.Replace(input, "", 1);
                    input = rgx.Replace(input, "", 1, input.LastIndexOf(pattern2));
                    Console.WriteLine("Shaked it.");

                    pattern2 = pattern2.Remove(pattern2.Length / 2, 1);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                    if (pattern == "")
                    {
                        Console.WriteLine("No shake.");
                        Console.WriteLine(input);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
