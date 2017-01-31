using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E09GrandTheftExamo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            ulong slappedTh = default(int);
            ulong allThieves = default(int);
            ulong beersDrunk = default(int);
            for (int i = 1; i<=n; i++)
            {
                uint thieves = uint.Parse(Console.ReadLine());
                uint beers = uint.Parse(Console.ReadLine());
                allThieves += thieves;
                slappedTh += (thieves > 5 ? 5 : thieves);
                beersDrunk += beers;

            }
            Console.WriteLine("{0} thieves slapped.\n{1} thieves escaped.\n{2} packs, {3} bottles.", slappedTh, allThieves-slappedTh, beersDrunk/6, beersDrunk%6);
        }
    }
}
