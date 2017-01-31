using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04DrawFilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            PrintDashes(count);
            PrintInsidePart(count);
            PrintDashes(count);
        }

        private static void PrintInsidePart(int count)
        {
            for(int row = 1; row<=count-2; row++)
            {
                for(int col =0; col<count*2; col++)
                {
                    if(col==0 || col==count*2-1)
                    {
                        Console.Write('-');
                    }
                    else if(col%2==1)
                    {
                        Console.Write('\\');
                    }
                    else
                    {
                        Console.Write('/');
                    }
                        
                }
                Console.WriteLine();
            }
        }

        private static void PrintDashes(int count)
        {
            Console.WriteLine(new string('-', count * 2));
        }
    }
}
