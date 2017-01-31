using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12CheckBitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int pstn = int.Parse(Console.ReadLine());
            uint input = uint.Parse(Console.ReadLine());
            input >>= pstn;
            uint num = 1 & input;
            if (num == 1)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
