using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime dateAsDate = DateTime.ParseExact(date, "d-M-yyyy", null);
            Console.WriteLine(dateAsDate.DayOfWeek);
        }
    }
}
