using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MaxSequenseOfEqualElements
{
    class MaxSequenseOfEqualElements
    {
        static void Main(string[] args)
        {
            List<int> inputNumsList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int numOfLongestSeq = inputNumsList[0];
            int numCurr = inputNumsList[0];
            int countCurr = 1;
            int countLongestSeq = 0;
            for (int i = 1; i < inputNumsList.Count; i++)
            {
                if (inputNumsList[i] == numCurr)
                {
                    countCurr++;
                    if (i != inputNumsList.Count - 1)
                    {
                        continue;
                    }
                }

                if (countCurr > countLongestSeq)
                {
                    countLongestSeq = countCurr;
                    numOfLongestSeq = numCurr;

                    countCurr = 1;
                    numCurr = inputNumsList[i];
                }
                else
                {
                    countCurr = 1;
                    numCurr = inputNumsList[i];
                }
            }

            for (int i = 1; i <= countLongestSeq; i++)
            {
                Console.Write("{0}{1}", numOfLongestSeq, i != countLongestSeq ? " " : "\n");
            }
        }
    }
}
