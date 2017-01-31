using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ExtractBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int pstn = 3;
            uint input = uint.Parse(Console.ReadLine());
            input >>= 3;
            Console.WriteLine(1 & input);
        }
    }
}
