using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03TextFilter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string textToReplaceWordsIn = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
               textToReplaceWordsIn = textToReplaceWordsIn.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
            }
            Console.WriteLine(textToReplaceWordsIn);
        }
    }
}
