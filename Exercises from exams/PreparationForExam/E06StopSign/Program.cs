using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06StopSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{0}", new string('.', n+1), new string('_', n*2 + 1));
            int cntDots = n+1;
            int cntDashes = n * 2-3;
            for (int i = 1; i < n * 2 + 1; i++)
            {
                if(i<=n)
                {
                    cntDots--;
                    cntDashes+=2;
                    //Console.WriteLine(cntDashes);
                    Console.WriteLine("{0}//{1}\\\\{0}", new string('.', cntDots), new string('_', cntDashes));
                }
                else if(i==n+1)
                {
                    cntDots--;
                    cntDashes+=2;
                    Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (n * 4 + 3)/2-4));
                    Console.WriteLine("\\\\{0}//", new string('_', n * 4 -1));
                }
                else
                {
                    cntDots++;
                    cntDashes-=2;
                    Console.WriteLine("{0}\\\\{1}//{0}", new string('.', cntDots), new string('_', cntDashes));
                }
                //Console.WriteLine();
            }
        }
    }
}
