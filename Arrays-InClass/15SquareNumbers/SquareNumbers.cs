using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<double> inputNumsList = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            int cnt = 0;
            while(cnt<=inputNumsList.Count-1)
            {
                double numToCheck = Math.Sqrt(inputNumsList[cnt]) * 10 % 10;
                if(numToCheck!=0)
                {
                    inputNumsList.Remove(inputNumsList[cnt]);
                    continue;
                }
                cnt++;
            }
            inputNumsList.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", inputNumsList));
        }
    }
}
