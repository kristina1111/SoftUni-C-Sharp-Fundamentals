using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E20OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hrExam = int.Parse(Console.ReadLine())*60;
            int mnExam = int.Parse(Console.ReadLine());
            int hrArival = int.Parse(Console.ReadLine())*60;
            int mnArival = int.Parse(Console.ReadLine());
            if(mnArival+hrArival > hrExam+mnExam)
            {
                Console.WriteLine("Late");
                if(mnArival + hrArival - hrExam - mnExam <60)
                {
                    Console.WriteLine("{0} minutes after the start", mnArival + hrArival - hrExam - mnExam);
                }
                else
                {
                    Console.WriteLine("{0}:{1:d2} hours after the start", (mnArival + hrArival - hrExam - mnExam)/60, (mnArival + hrArival - hrExam - mnExam)%60);
                }
            }
            else if(mnArival + hrArival<= hrExam + mnExam && mnArival + hrArival >= hrExam + mnExam - 30)
            {
                Console.WriteLine("On time");
                if (mnArival + hrArival != hrExam + mnExam)
                {
                    Console.WriteLine("{0} minutes before the start", hrExam + mnExam - mnArival - hrArival);
                }
            }
            else
            {
                Console.WriteLine("Early");
                if (hrExam + mnExam - mnArival - hrArival < 60)
                {
                    Console.WriteLine("{0} minutes before the start", hrExam + mnExam - mnArival - hrArival);
                }
                else
                {
                    Console.WriteLine("{0}:{1:d2} hours before the start", (hrExam + mnExam - mnArival - hrArival) / 60, (hrExam + mnExam - mnArival - hrArival) % 60);
                }
            }
        }
    }
}
