using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            List<string> inputArray = Console.ReadLine().Split(' ').ToList();
            int cntPrev = 0;
            int cntCurr = 1;

            string mostFreq = "";

            while (inputArray.Count != 0)
            {
                string toCheckFreq = inputArray[0];
                cntCurr = 1;
                inputArray.Remove(inputArray[0]);
                for (int i = 0; i < inputArray.Count; i++)
                {
                    if (toCheckFreq == inputArray[i])
                    {
                        cntCurr++;
                        inputArray.Remove(inputArray[i]);
                        i--;
                    }
                }

                if (cntPrev < cntCurr)
                {
                    cntPrev = cntCurr;
                    mostFreq = toCheckFreq;

                    continue;
                }
            }
            Console.WriteLine(mostFreq);
        }
    }
}
