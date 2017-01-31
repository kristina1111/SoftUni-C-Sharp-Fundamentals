using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            double daysLong = double.Parse(Console.ReadLine());
            double numRunners = double.Parse(Console.ReadLine());
            double numLaps = double.Parse(Console.ReadLine());
            double lengthTrack = double.Parse(Console.ReadLine());
            double trackCapacity = double.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            double maxNumRunners = trackCapacity * daysLong;
            double runnersToRun = numRunners;
            if(maxNumRunners<numRunners)
            {
                runnersToRun = maxNumRunners;
            }
            double TotalMetersRun = (runnersToRun * numLaps * lengthTrack) / 1000;
            decimal TotalMoneyRaised = (decimal)TotalMetersRun * moneyPerKm;
            Console.WriteLine("Money raised: {0:f2}",TotalMoneyRaised);
        }
    }
}
