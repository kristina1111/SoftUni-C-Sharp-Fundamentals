using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E12TorrentPirate
{
    class Program
    {
        static void Main(string[] args)
        {
            double dwnld = uint.Parse(Console.ReadLine());
            int prc = int.Parse(Console.ReadLine());
            int wfSpndHr = int.Parse(Console.ReadLine());
            double nMvs = dwnld / 1500;
            double priceCnm = nMvs * (double)prc;
            double wfSpnd = (dwnld / 2 / 60) * wfSpndHr / 60;

            if(priceCnm<wfSpnd)
            {
                Console.WriteLine("cinema -> {0:f2}lv", priceCnm);
            }
            else
            {
                Console.WriteLine("mall -> {0:f2}lv", wfSpnd);
            }


        }
    }
}
