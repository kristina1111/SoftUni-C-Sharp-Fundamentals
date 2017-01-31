using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02ProspectInHospitality
{
    class Program
    {
        static void Main(string[] args)
        {
            uint b = uint.Parse(Console.ReadLine());
            decimal result = b * 1500.04m;
            uint r = uint.Parse(Console.ReadLine());
            result += r * 2102.10m;
            uint c = uint.Parse(Console.ReadLine());
            result += c * 1465.46m;
            uint t = uint.Parse(Console.ReadLine());
            result += t * 2053.33m;
            uint o = uint.Parse(Console.ReadLine());
            result += o * 3010.98m;
            decimal ITpay = decimal.Parse(Console.ReadLine());
            decimal ITpayBG = decimal.Parse(Console.ReadLine()) * ITpay;
            result += ITpayBG;
            result += decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            Console.WriteLine("The amount is: {0:f2} lv.", result);

            if (budget>=result)
            {
                Console.WriteLine("YES \\ Left: {0:f2} lv.", budget-result);
            }
            else
            {
                Console.WriteLine("NO \\ Need more: {0:f2} lv.", result-budget);
            }
        }
    }
}
