using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02CountSubstringOccurances
{
    class CountSubstringOccurances
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();
            string substringToCheck = Console.ReadLine().ToLower();
            int cnt = 0;
            int inputTextLength = inputText.Length;
            int index = inputText.IndexOf(substringToCheck);
            while(!index.Equals(-1))
            {
                cnt++;
                index = inputText.IndexOf(substringToCheck, index + 1);
            }
            Console.WriteLine(cnt);
        }
    }
}
