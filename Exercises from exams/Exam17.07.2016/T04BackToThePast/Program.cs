using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            double frtn = double.Parse(Console.ReadLine());
            int yrToLive = int.Parse(Console.ReadLine());
            int yrsOld = 18;
            for(int i = 1800; i<=yrToLive; i++)
            {
                
                if(i%2==0)
                {
                    frtn = frtn - 12000;
                }
                else
                {
                    frtn = frtn - 12000 - 50 * yrsOld;
                }
                yrsOld++;
            }
            
            if(frtn>=0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", frtn);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(frtn));
            }
        }
    }
}
