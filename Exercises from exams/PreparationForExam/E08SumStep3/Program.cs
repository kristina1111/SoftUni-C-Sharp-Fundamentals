using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08SumStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayN = new int[n];
            int[] sum = new int[3];
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum[i % (sum.Length)] += arrayN[i];
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write("sum{0} {1} ", i + 1, sum[i]);
            }
            //Console.WriteLine("sum 1 = {0}", sum[0]);
        }
    }
}
