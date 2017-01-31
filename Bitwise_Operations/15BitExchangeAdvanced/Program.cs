using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15BitExchangeAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            byte pstnR = byte.Parse(Console.ReadLine());
            byte pstnL = byte.Parse(Console.ReadLine());
            byte k = byte.Parse(Console.ReadLine());
            long maskL = num >> pstnR;
            //Console.WriteLine(Convert.ToString(maskL, 2).PadLeft(32, '0'));

            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));

            //maksR <<= pstnR;
            maskL = (uint)(maskL << (32 - k));
            //Console.WriteLine(Convert.ToString(maskL, 2).PadLeft(32, '0'));
            maskL = (uint)(maskL>>(32 - (pstnL + k)));
            //Console.WriteLine(Convert.ToString(maskL,2).PadLeft(32,'0'));

            long maskR = (uint)(num << (32 - (pstnL + k)));
            //maskL >>= (32 - (pstnL + k));
            maskR = (uint)(maskR >>(32 - k));
            maskR <<= pstnR;
            Console.WriteLine(Convert.ToString(maskR, 2).PadLeft(32, '0'));

            string bin = default(string);
            for(int i = 0; i<k; i++)
            {
                bin += '1';
            }
            //Console.WriteLine(bin);

            int numBin = Convert.ToInt32(bin , 2);
            uint maskZ = (uint)numBin << pstnR;
            maskZ= ~maskZ;
            //Console.WriteLine(Convert.ToString(maskZ, 2).PadLeft(32, '0'));

            num = (num & maskZ);
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));

            maskZ = ~maskZ;
            maskZ <<= (pstnL - (pstnR));
            maskZ = ~maskZ;
            //Console.WriteLine(Convert.ToString(maskZ, 2).PadLeft(32, '0'));

            num = (num & maskZ);
            //Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));

            num = num | maskL;
            num = num | maskR;

            Console.WriteLine(num);

        }
    }
}
