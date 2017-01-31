using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10RemoveNegativesAndReverse
{
    class RemoveNegativesAndReverse
    {
        static void Main(string[] args)
        {
            List<int> listNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            bool isEmptyList = true;
            for(int i = listNums.Count-1; i>=0; i--)
            {
                if (listNums[i] < 0)
                {
                    listNums.Remove(listNums[i]);
                    continue;
                }
                Console.Write("{0}{1}", listNums[i], i != 0 ? " ":"\n");
                isEmptyList = false;
            }
            if(isEmptyList)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
