using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int century = int.Parse(Console.ReadLine());
                int years = century * 100;
                double days = (int)(years * 365.2422);
                double hours = (days * 24d);
                double minutes = (hours * 60d);
                double seconds = minutes * 60d;
                decimal milliseconds = (decimal)seconds * 1000m;
                decimal microseconds = milliseconds * 1000;
                decimal nanoseconds = microseconds * 1000;

                Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", century, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
                
            }

        }
    }
}
