using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Largest3Numbers
{
    class Largest3Numbers
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            numArr = numArr.OrderByDescending(x => x).Take(3).ToArray();
            Console.WriteLine(string.Join(" ", numArr));
        }
    }
}
