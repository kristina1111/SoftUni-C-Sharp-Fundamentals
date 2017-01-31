using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12SumAdjasentEqualNumbers
{
    class SumAdjasentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> mainList = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            //List<int> resultList = new List<int>();
            int cnt = 1;
            double numPrev = mainList[0];
            while(!(cnt > mainList.Count-1))
            {
                double numCurr = mainList[cnt];

                if (numPrev == numCurr)
                {
                    mainList[cnt-1] = numCurr * 2;
                    mainList.Remove(mainList[cnt]);
                    numPrev = mainList[0];
                    cnt = 1;
                    continue;
                }
                else
                {
                    numPrev = numCurr;
                    cnt++;
                }
            }
            Console.WriteLine(string.Join(" ", mainList));
        }
    }
}
