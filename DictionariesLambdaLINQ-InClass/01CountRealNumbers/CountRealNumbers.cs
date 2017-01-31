using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            double[] inputNumArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            SortedDictionary<double, int> sort = new SortedDictionary<double, int>();
            foreach(double num in inputNumArray)
            {
                if(sort.ContainsKey(num))
                {
                    sort[num]++;
                }
                else
                {
                    sort.Add(num, 1);
                }
            }
            foreach(KeyValuePair<double, int> pstn in sort)
            {
                Console.WriteLine("{0} -> {1}", pstn.Key, pstn.Value);
            }
        }
    }
}
