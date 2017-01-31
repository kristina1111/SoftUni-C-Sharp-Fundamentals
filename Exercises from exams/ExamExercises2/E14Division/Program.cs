using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E14Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[] pcnt = new double[3];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    pcnt[0]++;
                }
                if (num % 3 == 0)
                {
                    pcnt[1]++; ;
                }
                if (num % 4 == 0)
                {
                    pcnt[2]++;
                }
            }
            for (int i = 0; i < pcnt.Length; i++)
            {
                pcnt[i] = (pcnt[i] / n) * 100;
                Console.WriteLine("{0:f2}%", pcnt[i]);
            }

        }
    }
}
