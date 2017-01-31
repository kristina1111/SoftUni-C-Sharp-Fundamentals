using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08currencyCheck
{
    class Program
    {
        static void Main(string[] args)
        { 
            decimal rubles = (decimal.Parse(Console.ReadLine()) / 100) * 3.5m;
            decimal theCheapest = rubles;
            decimal dollars = decimal.Parse(Console.ReadLine()) * 1.5m;
            if(dollars<theCheapest)
            {
                theCheapest = dollars;
            }
            decimal euros = decimal.Parse(Console.ReadLine()) * 1.95m;
            if(euros<theCheapest)
            {
                theCheapest = euros;
            }
            decimal specOffB = decimal.Parse(Console.ReadLine()) / 2m;
            if(specOffB<theCheapest)
            {
                theCheapest = specOffB;
            }
            decimal priceSiteM = decimal.Parse(Console.ReadLine());
            if(priceSiteM<theCheapest)
            {
                theCheapest = priceSiteM;
            }
            Console.WriteLine("{0:f2}", theCheapest);
        }
    }
}
