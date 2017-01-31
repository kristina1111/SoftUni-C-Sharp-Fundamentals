using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08PointInCircleOutsideRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            bool checkCrcl = ((1.5 * 1.5) >= ((x - 1) * (x - 1) + (y - 1) * (y -1)));
            bool checkRctngl = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);
            if(checkRctngl==false)
            {
                if(checkCrcl==true)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
                
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
