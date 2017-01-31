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
            string[] weekDays = { "Invalid Day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int inputNum = int.Parse(Console.ReadLine());
            if(inputNum>=1 && inputNum<=7)
            {
                Console.WriteLine(weekDays[inputNum]);
            }
            else
            {
                Console.WriteLine(weekDays[0]);
            }
        }
    }
}
