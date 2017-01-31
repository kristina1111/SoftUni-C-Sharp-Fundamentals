using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03KingOfThieves
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            sbyte dotsNum = (sbyte)(n / 2);
            sbyte symbolNum = 1;
            for(int row = 1; row<=n; row++)
            {
                if(row<(n/2+1))
                {
                    Console.WriteLine("{0}{1}{0}", new string('-',dotsNum), new string(symbol, symbolNum));
                    dotsNum--;
                    symbolNum += 2;
                }
                else if(row == (n / 2 + 1))
                {
                    dotsNum = 1;
                    symbolNum = (sbyte)(n - 2);
                    Console.WriteLine("{0}", new string(symbol, n));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('-', dotsNum), new string(symbol, symbolNum));
                    dotsNum++;
                    symbolNum -= 2;
                }
            }
        }
    }
}
