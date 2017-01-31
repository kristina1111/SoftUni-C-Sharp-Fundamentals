using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceL = double.Parse(Console.ReadLine());
            int priceT = int.Parse(Console.ReadLine());
            int cntT = 0;
            int mnyPrsnt = 10;
            int powMny = 1;
            double smSvd = default(double); 
            for(int i =1; i<=age; i++)
            {
                if(i%2!=0)
                {
                    cntT++;
                }
                else
                {
                    smSvd = smSvd + mnyPrsnt * powMny-1;
                    powMny++;
                }
            }
            smSvd = smSvd + cntT * priceT;
            if(smSvd>=priceL)
            {
                Console.WriteLine("Yes! {0:f2}", smSvd-priceL);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceL-smSvd);
            }
        }
    }
}
