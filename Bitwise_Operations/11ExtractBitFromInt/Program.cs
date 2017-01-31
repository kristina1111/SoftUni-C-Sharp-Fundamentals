using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ExtractBitFromInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int pstn = int.Parse(Console.ReadLine());
            uint input = uint.Parse(Console.ReadLine());
            input >>= pstn;
            Console.WriteLine(1 & input);
        }
    }
}
