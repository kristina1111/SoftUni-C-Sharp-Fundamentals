using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E10Dumbbel
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int cntDots = num / 2;
            int cntStrs = num / 2 - 1;
            for (int row = 0; row < num; row++)
            {
                if (row == 0 || row == num - 1)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', num - (num + 1) / 2), new string('&', (num + 1) / 2), new string('.', num));
                }
                else if (row > 0 && row < num / 2)
                {
                    cntDots--;
                    cntStrs++;
                    Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', cntDots), new string('*', cntStrs), new string('.', num));
                }
                else if (row == num / 2)
                {
                    Console.WriteLine("&{0}&{1}&{0}&", new string('*', (num-2)), new string('=', num));
                }
                else
                {
                    Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', cntDots), new string('*', cntStrs), new string('.', num));
                    cntDots++;
                    cntStrs--;
                }

            }
        }
    }
}