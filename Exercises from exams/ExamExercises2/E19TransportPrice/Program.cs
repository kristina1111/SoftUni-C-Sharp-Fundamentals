using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E19TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();
            if(km<20)
            {
                switch(dayOrNight)
                {
                    case "day": Console.WriteLine((double)km*0.79+0.70); break;
                    case "night": Console.WriteLine((double)km * 0.90 + 0.70); break;
                }
            }
            else if(km>=20 && km<100)
            {
                Console.WriteLine((double)km*0.09);
            }
            else if(km>=100)
            {
                Console.WriteLine((double)km*0.06);
            }
        }
    }
}
