using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E13SummertimeBeer
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}", new string(' ', (n*2-(n+1))/2), new string('*', n+1));
            for(int i = 1, k = 0, m=0; i<=n-1; i++)
            {
                if(i<=n-n/2)
                {
                    Console.WriteLine("{0}*{1}*", new string(' ', (n * 2 - (n + 1)) / 2), new string(' ', n + 1-2));
                }
                else
                {
                    k++;
                    m += 2;
                    Console.WriteLine("{0}*{1}*", new string(' ', (n * 2 - (n + 1)) / 2-k), new string(' ', n + 1 - 2+m));
                }
            }

            for (int i = 1; i<=n*2; i++)
            {
                if(i<=n)
                {
                    Console.WriteLine("*{0}*", new string('.', n*2-2));
                }
                else
                {
                    Console.WriteLine("*{0}*", new string('@', n * 2 - 2));
                }
            }

            Console.WriteLine(new string('*', n * 2));

        }
    }
}
