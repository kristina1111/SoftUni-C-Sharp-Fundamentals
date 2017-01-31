using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PointInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool check = ((2 * 2 )> ((x - 0) * (x - 0) + (y - 0) * (y - 0)));
            Console.WriteLine(check);
        }
    }
}
