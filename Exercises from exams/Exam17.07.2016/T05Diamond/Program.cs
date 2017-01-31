using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dotCntSides = n - 1;
            int dotCntIn = n * 3;
            for(int i = 1; i<=n; i++)
            {
                if(i==1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n*3));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{0}", new string('.', dotCntSides), new string('.', dotCntIn));
                    dotCntSides--;
                    dotCntIn += 2;
                }
            }
            Console.WriteLine(new string('*', n*5));

            dotCntSides=1;
            dotCntIn = n*5-4;
            for (int i = 1; i<=n*2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}", new string('.', dotCntSides), new string('.', dotCntIn));
                dotCntSides++;
                dotCntIn -= 2;
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', dotCntSides), new string('*', n*5 - 2*dotCntSides-2));

        }
    }
}
