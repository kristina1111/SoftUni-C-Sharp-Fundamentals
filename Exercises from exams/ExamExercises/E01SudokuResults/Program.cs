using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01SudokuResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(':').ToArray();
            int totalMins = default(int);
            int cnt = default(int);
            while(input[0] != "Quit")
            {
                int mins = int.Parse(input[0]) * 60 + int.Parse(input[1]);
                totalMins += mins;
                cnt += 1;

                input = Console.ReadLine().Split(':').ToArray();
            }
            if (Math.Ceiling((double)totalMins / cnt) < 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if (Math.Ceiling((double)totalMins / cnt) >= 720 && Math.Ceiling((double)totalMins / cnt) < 1440)
            {
                Console.WriteLine("Silver Star");
            }
            else if (Math.Ceiling((double)totalMins /cnt) >= 1440)
            {
                Console.WriteLine("Bronze Star");
            }

            Console.WriteLine("Games - {0} \\ Average seconds - {1}", cnt, Math.Ceiling((double)totalMins /cnt));
        }
    }
}
