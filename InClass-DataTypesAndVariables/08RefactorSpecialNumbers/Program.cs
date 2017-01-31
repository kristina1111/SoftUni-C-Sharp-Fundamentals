using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int takova = 0;
            bool toe = false;
            for (int ch = 1; ch <= kolkko; ch++)
            {
                takova = ch;
                while (ch > 0)
                {
                    obshto += ch % 10;
                    ch = ch / 10;
                }
                toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
                Console.WriteLine($"{takova} -> {toe}");
                obshto = 0;
                ch = takova;
            }
        }
    }
}
