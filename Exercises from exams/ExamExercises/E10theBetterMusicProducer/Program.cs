using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E10theBetterMusicProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort nSoldEu = ushort.Parse(Console.ReadLine());
            decimal priceEu = decimal.Parse(Console.ReadLine());
            ushort nSoldNAm = ushort.Parse(Console.ReadLine());
            decimal priceDoll = decimal.Parse(Console.ReadLine());
            ushort nSoldSAm = ushort.Parse(Console.ReadLine());
            decimal pricePesos = decimal.Parse(Console.ReadLine());
            ushort numConc = ushort.Parse(Console.ReadLine());
            decimal profitConc = decimal.Parse(Console.ReadLine());

            decimal totalProfAlb = nSoldEu * priceEu * 1.94m + nSoldNAm * priceDoll * 1.72m + nSoldSAm * pricePesos / 332.74m;
            totalProfAlb = (totalProfAlb - totalProfAlb * 0.35m) * 0.8m;

            decimal totalConcProf = numConc * profitConc * 1.94m;
            totalConcProf = (totalConcProf - (totalConcProf > 100000 ? totalConcProf * 0.15m : 0));

            if (totalProfAlb>totalConcProf)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.", totalProfAlb);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", totalConcProf);
            }
        }
    }
}
