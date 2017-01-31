using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04BookProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            uint nPgs = uint.Parse(Console.ReadLine());
            sbyte nCmpMnt = sbyte.Parse(Console.ReadLine());
            sbyte nPgsDay = sbyte.Parse(Console.ReadLine());
            uint pgsRead = ((uint)((30 - nCmpMnt) * nPgsDay));
            //uint pgsMonth = nPgs / ((uint)((30 - nCmpMnt) * nPgsDay));
            if (pgsRead == 0)
            {
                Console.WriteLine("never");
            }
            else
            {
                double pgsMonth = (double)nPgs / ((double)((30 - nCmpMnt) * nPgsDay));
                Console.WriteLine("{0} years {1} months", Math.Round(pgsMonth / 12), Math.Ceiling(pgsMonth%12));
            }
            
        }
    }
}
