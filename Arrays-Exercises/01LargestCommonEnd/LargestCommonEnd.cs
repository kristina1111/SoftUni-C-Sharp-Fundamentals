using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] wordArray1 = Console.ReadLine().Split(' ').ToArray();
            string[] wordArray2 = Console.ReadLine().Split(' ').ToArray();

            int commonLeftEnd = GetLeftCommonEnd(wordArray1, wordArray2);
            int commonRightEnd = GetRightCommonEnd(wordArray1, wordArray2);

            Console.WriteLine(commonRightEnd >= commonLeftEnd ? commonRightEnd : commonLeftEnd);
        }

        private static int GetRightCommonEnd(string[] wordArray1, string[] wordArray2)
        {
            int count = 0;
            int arrayLength = Math.Min(wordArray1.Length, wordArray2.Length) - 1;
            for (int i = 0; i <= arrayLength; i++)
            {
                if (wordArray1[wordArray1.Length - 1 - i] == wordArray2[wordArray2.Length - 1 - i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }

        private static int GetLeftCommonEnd(string[] wordArray1, string[] wordArray2)
        {
            int count = 0;
            int arrayLength = Math.Min(wordArray1.Length, wordArray2.Length) - 1;
            for (int i = 0; i <= arrayLength; i++)
            {
                if (wordArray1[i] == wordArray2[i])
                {
                    count++;
                }
                else
                {
                    break;
                }
            }
            return count;
        }
    }
}
