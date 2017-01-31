using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E20CompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal priceTV = decimal.Parse(Console.ReadLine());
            uint nYears = uint.Parse(Console.ReadLine());
            decimal intBank = decimal.Parse(Console.ReadLine());
            decimal intFriend = decimal.Parse(Console.ReadLine());

            decimal retBank;
            decimal retFriend;
            decimal multiplierB = 1;
            decimal multiplierF = 1;
            for(uint i = 1; i<=nYears; i++)
            {
                multiplierB *= (1 + intBank);
            }
            multiplierF *= (1 + intFriend);

            retBank = priceTV * multiplierB;
            retFriend = priceTV * multiplierF;

            if(retBank<retFriend)
            {
                Console.WriteLine("{0:f2} Bank", retBank);
            }
            else
            {
                Console.WriteLine("{0:f2} Friend", retFriend);
            }
        }
    }
}
