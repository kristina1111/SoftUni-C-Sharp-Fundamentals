using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06BaiIvanAdventures
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte dayOfWeek = sbyte.Parse(Console.ReadLine());
            decimal moneyGot = decimal.Parse(Console.ReadLine());
            decimal ltrsWanted = decimal.Parse(Console.ReadLine());
            decimal costLtrs = default(decimal);
            switch (dayOfWeek)
            {
                case 0:
                    costLtrs = 25.0m;
                    break;
                case 1:
                    costLtrs = 21.0m;
                    break;
                case 2:
                    costLtrs = 14.0m;
                    break;
                case 3:
                    costLtrs = 17.0m;
                    break;
                case 4:
                    costLtrs = 45.0m;
                    break;
                case 5:
                    costLtrs = 59.0m;
                    break;
                case 6:
                    costLtrs = 42.0m;
                    break;
                default:
                    Console.WriteLine("Invalid day of week");
                    break;
            }

            string condition = default(string);
            if (moneyGot / costLtrs > 1.5m)
            {
                condition = "very drunk";
            }
            else if(moneyGot / costLtrs < 1.5m && moneyGot / costLtrs >= 1.0m)
            {
                condition = "drunk";
            }
            else if(moneyGot / costLtrs < 1m)
            {
                condition = "sober";
            }

            if (moneyGot/costLtrs >ltrsWanted)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:f2} l. of alcohol with his friends", condition, moneyGot / costLtrs - ltrsWanted);
            }
            else if(moneyGot / costLtrs == ltrsWanted)
            {
                Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
            }
            else
            {
                Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:f2} l. of alcohol", condition, Math.Abs(moneyGot / costLtrs - ltrsWanted));
            }
             
        }
    }
}
