using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01CountWorkingDays
{
    class CountWorkingDays
    {
        static void Main(string[] args)
        {
            DateTime inputDate1 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            //string dateToCheck = inputDate1.Day + " " + inputDate1.Month;
            //Console.WriteLine(dateToCheck);
            DateTime inputDate2 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", null);
            string[] hollidaysArray = { "1 1", "3 3", "1 5", "6 5", "24 5", "6 9", "22 9", "1 11", "24 12", "25 12", "26 12" };
            int cntWorkingDays = 0;
            for (DateTime i = inputDate1; i <= inputDate2; i = i.AddDays(1))
            {
                string dateToCheck = i.Day + " " + i.Month;
                string dayOfWeek = i.DayOfWeek.ToString();
                if (dayOfWeek== "Saturday" || dayOfWeek=="Sunday" || hollidaysArray.Contains(dateToCheck))
                {
                    continue;
                }
                else 
                {
                    cntWorkingDays++;
                }
            }
            Console.WriteLine(cntWorkingDays);
        }
    }
}
