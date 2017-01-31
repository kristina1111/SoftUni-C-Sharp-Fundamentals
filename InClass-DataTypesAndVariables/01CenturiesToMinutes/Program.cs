using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cntry = int.Parse(Console.ReadLine());
            long years = (long)cntry * 100;
            long days = (long)(years * 365.2422);
            ulong hours = (ulong)days * 24;
            double minutes = (double)hours * 60;
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes", cntry, years, days, hours, minutes); 
        }
    }
}
