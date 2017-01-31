using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ModifyBitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            byte value = byte.Parse(Console.ReadLine());
            byte pstn = byte.Parse(Console.ReadLine());
            uint mask = 1;
            if(value == 0)
            {
                mask <<= pstn;
                //mask = ~mask;
                num = (num & ~mask);
            }
            else
            {
                mask <<= pstn;
                num = (num | mask);
            }
            Console.WriteLine(num);
        }
    }
}
