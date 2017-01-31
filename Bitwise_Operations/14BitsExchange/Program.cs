using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14BitsExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            uint maskRight = num << 5;
            maskRight >>= 29;
            maskRight <<= 3;
            //Console.WriteLine(Convert.ToString(maskRight, 2).PadLeft(32, '0'));
            uint maskLeft = num >> 3;
            ////Console.WriteLine(Convert.ToString(maskLeft, 2).PadLeft(32, '0'));
            maskLeft = maskLeft << 29;
            maskLeft >>= 5;
            //Console.WriteLine(Convert.ToString(maskLeft, 2).PadLeft(32,'0'));

            uint maskZero = 7;
            maskZero <<= 3;
            maskZero = ~maskZero;
            
            num = (num & maskZero);
            maskZero = ~maskZero;

            maskZero <<= 21;
            maskZero = ~maskZero;
            //Console.WriteLine(Convert.ToString(maskZero, 2).PadLeft(32, '0'));
            num = (num & maskZero);
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));

            num = (num | maskLeft);
            num = (num | maskRight);
            Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine(num);
        }
    }
}
