using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09HolidaysBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            //This code doesn't work! Judge - 12/100
            DateTime startDate = DateTime.Parse(Console.ReadLine());
            DateTime endDate = DateTime.Parse(Console.ReadLine());
            int count = 0;
            //string nameOfDay = startDate.DayOfWeek.ToString();
            //Console.WriteLine(nameOfDay);

            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);


            ////This code works! Judge - 100/100
            //var startDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            //var endDate = DateTime.ParseExact(Console.ReadLine(), "d.M.yyyy", CultureInfo.InvariantCulture);
            //var holidaysCount = 0;
            //for (var date = startDate; date <= endDate; date = date.AddDays(1))
            //{
            //    if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            //    {
            //        holidaysCount++;
            //    }
            //}

            //Console.WriteLine(holidaysCount);

        }
    }
}
