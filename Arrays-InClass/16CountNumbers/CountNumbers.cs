using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            int[] numsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            SortedDictionary<int, int> numsOccur = new SortedDictionary<int, int>();
            for(int i = 0; i<numsArray.Length; i++)
            {
                if(numsOccur.ContainsKey(numsArray[i]))
                {
                    numsOccur[numsArray[i]]++;
                }
                else
                {
                    numsOccur.Add(numsArray[i], 1);
                }
            }
            foreach(KeyValuePair<int, int> p in numsOccur)
            {
                Console.WriteLine("{0} -> {1}", p.Key, p.Value);
            }
        }
    }
}
