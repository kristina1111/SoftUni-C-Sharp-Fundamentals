using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E16FourFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            long FG = long.Parse(Console.ReadLine());
            long FGA = long.Parse(Console.ReadLine());
            long P3 = long.Parse(Console.ReadLine());
            long TOV = long.Parse(Console.ReadLine());
            long ORB = long.Parse(Console.ReadLine());
            long OppDRB = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FTA = long.Parse(Console.ReadLine());

            decimal eFG = (FG + 0.5m * P3) / FGA;
            Console.WriteLine("eFG% {0:f3}", eFG);

            decimal pTOV = TOV / (FGA + 0.44m * FTA + TOV);
            Console.WriteLine("TOV% {0:f3}", pTOV);

            decimal pORB = (decimal)ORB / (ORB + OppDRB);
            Console.WriteLine("ORB% {0:f3}", pORB);

            decimal pFT = (decimal)FT / FGA;

            Console.WriteLine("FT% {0:f3}", pFT );
        }
    }
}
