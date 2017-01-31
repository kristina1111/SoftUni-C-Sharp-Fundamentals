using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(' ').ToArray();
            string longerSequence = inputArray[0] + " ";
            string longerLeftSequence = inputArray[0] + " ";
            int cntPrev = 0;
            int cntCurr = 1;
            bool hasPassedFirstIf = true;
            for (int i = 1; i < inputArray.Length; i++)
            {
                if (inputArray[i] == inputArray[i - 1])
                {
                    longerSequence += inputArray[i] + " ";
                    //longerLeftSequence += inputArray[i] + " ";
                    cntCurr++;
                    if (i == inputArray.Length - 1 && cntPrev < cntCurr)
                    {
                        //cntPrev = cntCurr;
                        longerLeftSequence = longerSequence;
                    }
                    continue;
                }
                hasPassedFirstIf = false;
                if (cntPrev < cntCurr)
                {
                    cntPrev = cntCurr;
                    longerLeftSequence = longerSequence;

                    longerSequence = inputArray[i] + " ";
                    cntCurr = 1;

                    continue;
                }
                longerSequence = inputArray[i] + " ";
                cntCurr = 1;
            }
            if (hasPassedFirstIf)
            {
                longerLeftSequence = longerSequence;
            }
            Console.WriteLine(longerLeftSequence);
        }
    }
}
