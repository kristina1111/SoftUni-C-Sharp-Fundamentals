using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float inputMeters = float.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float totalSec = (hours * 60 * 60 + minutes * 60 + seconds);
            float totalHours = totalSec / 60 / 60;
            //float metersPerSec = inputMeters / totalSec;
            Console.WriteLine(inputMeters / totalSec);
            //float kmPerHours = inputMeters / 1000 / totalHours;
            Console.WriteLine(inputMeters / 1000 / totalHours);
            //float milesPerHour = inputMeters / 1609 / totalHours;
            Console.WriteLine(inputMeters / 1609 / totalHours);
        }
    }
}
