using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E17VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double prcVeg = double.Parse(Console.ReadLine());
            double prcFru = double.Parse(Console.ReadLine());
            int kgVeg = int.Parse(Console.ReadLine());
            int kgFru = int.Parse(Console.ReadLine());
            double revenue = (prcVeg * kgVeg + prcFru * kgFru) / 1.94;
            Console.WriteLine(revenue);
        }
    }
}
