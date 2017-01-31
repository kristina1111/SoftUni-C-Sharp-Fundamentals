using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> mappingChars = new Dictionary<char, char>();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string word1 = input[0];
            string word2 = input[1];
            if (word1.Length < word2.Length)
            {
                string temp = word1;
                word1 = word2;
                word2 = temp;
            }
            bool isExchangeable = true;
            int cnt = -1;
            for (int i = 0; i < word1.Length; i++)
            {
                cnt++;
                if (cnt < word2.Length)
                {
                    if (mappingChars.ContainsKey(word1[i]))
                    {
                        if (mappingChars[word1[i]] != word2[cnt])
                        {
                            isExchangeable = false;
                            break;
                        }
                    }
                    else if (mappingChars.ContainsValue(word2[cnt]))
                    {
                        isExchangeable = false;
                        break;
                    }
                    else
                    {
                        mappingChars.Add(word1[i], word2[cnt]);
                    }
                }
                else
                {
                    if(!mappingChars.ContainsKey(word1[i]))
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }
            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
