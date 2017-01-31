using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05DrunkAni
{
    class Program
    {
        static void Main(string[] args)
        {
            //uint[] numCabs = new uint[uint.Parse(Console.ReadLine())];

            //int n = 8 % 5;
            //Console.WriteLine(n);
            
            long numCabs = uint.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            long currCab = 0;
            long totalSteps = 0;
            long stepsToGo = 0;
            while (input != "Found a free one!")
            {
                //uint steps = uint.Parse(input);
                long cabForCheck = (long.Parse(input)+currCab)%numCabs;
                stepsToGo = cabForCheck - currCab;
                currCab = cabForCheck;
                if(stepsToGo>0)
                {
                    Console.WriteLine("Go {0} steps to the right, Ani.", stepsToGo);
                }
                else if(stepsToGo<0)
                {
                    Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(stepsToGo));
                }
                else if(stepsToGo==0)
                {
                    Console.WriteLine("Stay there, Ani.");
                }
                totalSteps += Math.Abs(stepsToGo);
                //stepsToGo
                input = Console.ReadLine();
            }
            Console.WriteLine("Moved a total of {0} steps.", totalSteps);

        }
    }
}
