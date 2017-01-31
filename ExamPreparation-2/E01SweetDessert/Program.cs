using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01SweetDessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal moneyHas = decimal.Parse(Console.ReadLine());
            double numGuests = int.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());

            double numPortionsNeeded = Math.Ceiling(numGuests / 6);
            decimal moneyNeeded = (2m * priceBananas + 4m * priceEggs + priceBerries * 0.2m) * (decimal)numPortionsNeeded;
            if(moneyNeeded<=moneyHas)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", moneyNeeded);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", moneyNeeded-moneyHas);
            }
        }
    }
}
