using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string[] inputText = Console.ReadLine().Split(new[] {' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> resultToPrint = new List<string>();
            for(int i = 0; i< inputText.Length; i++)
            {
                if(IsPalindrome(inputText[i]))
                {
                    resultToPrint.Add(inputText[i]);
                }
            }
            resultToPrint = resultToPrint.Distinct().OrderBy(w => w).ToList();
            Console.WriteLine(string.Join(", ", resultToPrint));
        }

        private static bool IsPalindrome(string word)
        {
            string reversedWord = new string(word.ToCharArray().Reverse().ToArray());
            if(word == reversedWord)
            {
                return true;
            }
            return false;
        }
    }
}
