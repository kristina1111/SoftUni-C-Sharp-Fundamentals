using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int hghtArea = int.Parse(Console.ReadLine());
            double wdthTile = double.Parse(Console.ReadLine());
            double hgthTile = double.Parse(Console.ReadLine());
            int wdthBench = int.Parse(Console.ReadLine());
            int hghtBench = int.Parse(Console.ReadLine());

            int AreaToRpre = hghtArea * hghtArea - wdthBench * hghtBench;
            double AreaTile = wdthTile * hgthTile;
            double TilesNeeded = (double)AreaToRpre / AreaTile;
            double TimeNeeded = TilesNeeded * 0.2;
            Console.WriteLine(TilesNeeded);
            Console.WriteLine(TimeNeeded);

        }
    }
}
