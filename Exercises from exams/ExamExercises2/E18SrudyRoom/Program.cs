using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E18SrudyRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine())*100;
            double height = double.Parse(Console.ReadLine())*100;
            int numPl = (((int)height - 100) / 70) * ((int)width/120) - 3;
            Console.WriteLine(numPl);
        }
    }
}
