using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E10Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int nBricks = int.Parse(Console.ReadLine());
            int nWorkers = int.Parse(Console.ReadLine());
            int vTrollye = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling(((double)nBricks/vTrollye)/nWorkers));
        }
    }
}
