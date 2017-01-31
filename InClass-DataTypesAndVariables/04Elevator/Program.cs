using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPrsns = int.Parse(Console.ReadLine());
            int cpcty = int.Parse(Console.ReadLine());
            int cources = numPrsns/cpcty;
            if (+numPrsns % cpcty !=0)
            {
                cources++;
            }
            Console.WriteLine(cources);
        }
    }
}
