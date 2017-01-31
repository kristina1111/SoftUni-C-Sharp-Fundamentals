using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02OddOccurances
{
    class OddOccurances
    {
        static void Main(string[] args)
        {
            string[] inputWordsArray = Console.ReadLine().ToLower().Split(' ').ToArray();
            Dictionary<string, int> wordOccurance = new Dictionary<string, int>();
            foreach(string word in inputWordsArray)
            {
                if(wordOccurance.ContainsKey(word))
                {
                    wordOccurance[word]++;
                }
                else
                {
                    wordOccurance.Add(word, 1);
                }
            }
            string resultToPrint = "";
            foreach(KeyValuePair<string, int> word in wordOccurance)
            {
                if(word.Value%2==1)
                {
                    resultToPrint+= word.Key+", ";
                }
            }
            resultToPrint = resultToPrint.TrimEnd(new[] {',', ' '});
            Console.WriteLine(resultToPrint);
        }
    }
}
