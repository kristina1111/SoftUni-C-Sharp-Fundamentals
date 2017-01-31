using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int frst = int.Parse(Console.ReadLine());
            int scnd = int.Parse(Console.ReadLine());
            
            if(frst>scnd)
            {
                int temp = frst;
                frst = scnd;
                scnd = temp;
            }
            int pnt = int.Parse(Console.ReadLine());
            int clstP = (Math.Abs(frst-pnt)<Math.Abs(scnd-pnt) ? Math.Abs(frst - pnt) : Math.Abs(scnd - pnt));
            if(pnt >=frst && pnt<=scnd)
            {
                Console.WriteLine("in\n{0}", clstP);
            }
            else
            {
                Console.WriteLine("out\n{0}", clstP);
            }
                
        }
    }
}
