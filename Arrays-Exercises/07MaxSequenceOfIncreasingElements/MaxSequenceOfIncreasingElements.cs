using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07MaxSequenceOfIncreasingElements
{
    class MaxSequenceOfIncreasingElements
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int cnt = 1;
            int cntCurrSeq = 1;
            int cntLongestLeftSeq = 0;
            string currentSeq = "" + numArray[0] + " ";
            string longestSeq = currentSeq;

            while (cnt < numArray.Length)
            {
                //cnt++;
                if (numArray[cnt] > numArray[cnt - 1])
                {
                    currentSeq += numArray[cnt] + " ";
                    cntCurrSeq++;
                    
                    if(cnt != numArray.Length-1)
                    {
                        cnt++;
                        continue;
                    }
                    
                }

                if (cntCurrSeq > cntLongestLeftSeq)
                {
                    cntLongestLeftSeq = cntCurrSeq;
                    cntCurrSeq = 1;

                    longestSeq = currentSeq;
                    currentSeq = "" + numArray[cnt] + " ";
                }
                currentSeq = "" + numArray[cnt] + " ";
                cntCurrSeq = 1;
                cnt++;
            }
            Console.WriteLine(longestSeq.TrimEnd(' '));
        }
    }
}
