using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14SortNumbers
{
    class SortNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> listNums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            listNums.Sort();
            Console.WriteLine(string.Join(" <= ", listNums));
        }
    }
}
