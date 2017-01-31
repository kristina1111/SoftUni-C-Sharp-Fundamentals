using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E15Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double bdgt = double.Parse(Console.ReadLine());
            string sesn = Console.ReadLine();
            string dstntn = default(string);
            string plcSt = default(string);
            double mnSpnt = default(double);
            if(bdgt<=100)
            {
                dstntn = "Bulgaria";
                switch(sesn)
                {
                    case "summer": mnSpnt = bdgt * 0.3; plcSt = "Camp"; break;
                    case "winter": mnSpnt = bdgt * 0.7; plcSt = "Hotel"; break;
                }
            }
            else if(bdgt>100 && bdgt <= 1000)
            {
                dstntn = "Balkans";
                switch (sesn)
                {
                    case "summer": mnSpnt = bdgt * 0.4; plcSt = "Camp"; break;
                    case "winter": mnSpnt = bdgt * 0.8; plcSt = "Hotel"; break;
                }
            }
            else if(bdgt>1000)
            {
                dstntn = "Europe";
                plcSt = "Hotel";
                mnSpnt = bdgt * 0.9;
            }
            Console.WriteLine("Somewhere in {0}", dstntn);
            Console.WriteLine("{0} - {1:f2}", plcSt, mnSpnt);
        }
    }
}