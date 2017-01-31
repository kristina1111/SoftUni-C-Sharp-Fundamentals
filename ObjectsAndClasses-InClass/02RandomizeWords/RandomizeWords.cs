using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            string[] wordArray = Console.ReadLine().Split(' ').ToArray();
            string[] randomArray = new string[wordArray.Length];
            Random rnd = new Random();
            int cnt = 0;
            while(cnt<randomArray.Length)
            {
                int rndNum = rnd.Next(0, wordArray.Length);
                while(!randomArray.Contains(wordArray[rndNum]))
                {
                    randomArray[cnt] = wordArray[rndNum];
                    Console.WriteLine(randomArray[cnt]);
                    cnt++;
                    break;
                }
            }
        }
    }
}
