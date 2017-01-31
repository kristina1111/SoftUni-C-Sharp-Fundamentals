using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            string month = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(((day.Length < 2 ? "0" + day : day) + (month.Length<2 ? "0"+month : month)+2013), "ddMMyyyy", null);
            DateTime endDate = startDate.AddDays(5);

            Console.WriteLine("{0:d.MM}", endDate);
        }
    }
}
