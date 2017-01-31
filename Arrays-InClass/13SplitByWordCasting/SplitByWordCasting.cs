using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13SplitByWordCasting
{
    class SplitByWordCasting
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine()
                                    .Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions
                                    .RemoveEmptyEntries)
                                    .ToArray();
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> MixedCaseWords = new List<string>();
            for(int i =0; i<inputArray.Length; i++)
            {
                int cntUpper = 0;
                int cntLower = 0;
                for(int k =0; k<inputArray[i].Length; k++)
                {
                    if(inputArray[i][k]>=97 && inputArray[i][k]<=122)
                    {
                        cntLower++;
                    }
                    else if(inputArray[i][k] >= 65 && inputArray[i][k] <= 90)
                    {
                        cntUpper++;
                    }
                    else
                    {
                        cntLower++;
                        cntUpper++;
                    }

                    if (cntLower > 0 && cntUpper > 0)
                    {
                        break;
                    }
                }

                if (cntLower > 0 && cntUpper > 0)
                {
                    MixedCaseWords.Add(inputArray[i]);
                    continue;
                }
                else if(cntLower > 0 && cntUpper == 0)
                {
                    lowerCaseWords.Add(inputArray[i]);
                    continue;
                }
                else if(cntLower == 0 && cntUpper > 0)
                {
                    upperCaseWords.Add(inputArray[i]);
                    continue;
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseWords));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", MixedCaseWords));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseWords));

        }
    }
}
