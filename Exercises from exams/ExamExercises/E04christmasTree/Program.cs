using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04christmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int Rowspart = n/2 + 1;
            int snow = n;
            int leaf = 1;
            for(int i = 1; i<=Rowspart; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'', snow), new string('^', leaf));
                
                snow--;
                leaf += 2;
            }
            snow = n - 1;
            leaf = 3;
            for (int i = 1; i <= Rowspart; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('\'', snow), new string('^', leaf));

                snow--;
                leaf += 2;
            }
            snow = n - 1;
            for (int i = 1; i <= Rowspart; i++)
            {
                Console.WriteLine("{0}| |{0}", new string('\'', snow));
                
            }
            Console.WriteLine(new string('-', n*2+1));

        }
    }
}
