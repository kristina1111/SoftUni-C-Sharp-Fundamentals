using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bdgt = decimal.Parse(Console.ReadLine());
            string ctgry = Console.ReadLine().ToLower();
            int numPpl = int.Parse(Console.ReadLine());
            if(numPpl>=1 && numPpl<=4)
            {
                bdgt = bdgt - bdgt * 0.75m;
            }
            else if(numPpl>=5 && numPpl<=9)
            {
                bdgt = bdgt - bdgt * 0.60m;
            }
            else if(numPpl>=10 && numPpl<=24)
            {
                bdgt = bdgt - bdgt * 0.50m;
            }
            else if(numPpl>=25 && numPpl<=49)
            {
                bdgt = bdgt - bdgt * 0.40m;
            }
            else if(numPpl>=50)
            {
                bdgt = bdgt - bdgt * 0.25m;
            }
            decimal mnyNeeded = default(decimal);
            if(ctgry=="vip")
            {
                mnyNeeded = 499.99m * numPpl;
            }
            else if(ctgry == "normal")
            {
                mnyNeeded = 249.99m * numPpl;
            }


            if(bdgt>=mnyNeeded)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.",bdgt-mnyNeeded);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", mnyNeeded-bdgt);
            }
        }
    }
}
