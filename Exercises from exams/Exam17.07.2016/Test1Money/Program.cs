using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBitcn = int.Parse(Console.ReadLine())*1168;
            double chinYan = double.Parse(Console.ReadLine());
            double commPcnt = double.Parse(Console.ReadLine());
            chinYan = chinYan * 0.15 * 1.76;
            double allMoney = (numBitcn + chinYan) / 1.95;
            allMoney = allMoney - (allMoney * commPcnt) / 100;
            Console.WriteLine(allMoney);
        }
    }
}
