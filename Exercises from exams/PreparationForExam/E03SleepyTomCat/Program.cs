using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            short holidays = short.Parse(Console.ReadLine());
            int timeForPlay = (365 - holidays) * 63 + holidays * 127;
            if(timeForPlay<=30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", (30000-timeForPlay)/60, (30000 - timeForPlay) % 60);
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", (timeForPlay-30000) / 60, (timeForPlay-30000) % 60);
            }

        }
    }
}
