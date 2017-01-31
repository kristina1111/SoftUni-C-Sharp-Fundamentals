using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18TheaThePhotographer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numPics = int.Parse(Console.ReadLine());
            int timeToFilter = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int timeToUpload = int.Parse(Console.ReadLine());

            double totalSeconds = (double)numPics * timeToFilter + Math.Ceiling((double)numPics * filterFactor / 100d) * timeToUpload; //(double)
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
            string result = string.Format("{0}:{01:D2}:{02:D2}:{03:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
            Console.WriteLine(result);

            //int days = (int)(totalSeconds / (24 * 60 * 60));
            //int hours = (int)((totalSeconds % (24 * 60 * 60)) / 3600);
            //int min = (int)(((totalSeconds % (24 * 60 * 60)) % 3600) / 60);
            //int sec = (int)(((totalSeconds % (24 * 60 * 60)) % 3600) % 60);
            //Console.WriteLine("{0}:{1:D2}:{2:D2}:{3:D2}", days, hours, min, sec);
        }
    }
}
