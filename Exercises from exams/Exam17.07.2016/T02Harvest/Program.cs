using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                double kvM = double.Parse(Console.ReadLine());
                double qGrape = double.Parse(Console.ReadLine());
                double ltNeeded = double.Parse(Console.ReadLine());
                int numWorkers = int.Parse(Console.ReadLine());
                double totalGrape = ((kvM * qGrape) * 0.4) / 2.5;

                if (totalGrape >= ltNeeded)
                {
                    Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(totalGrape));
                    Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(totalGrape - ltNeeded), Math.Ceiling((totalGrape - ltNeeded) / numWorkers));
                }
                else
                {
                    Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(ltNeeded - totalGrape));
                }
            }
            
        }
    }
}
