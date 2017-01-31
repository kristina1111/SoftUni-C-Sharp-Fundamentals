using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11StripedTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            char[] arrStripe = new char[n];

            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0)
                {
                    arrStripe[i] = '#';
                    Console.Write(arrStripe[i]);
                }
                else
                {
                    arrStripe[i] = '.';
                    Console.Write(arrStripe[i]);
                }
            }
            Console.WriteLine();

            for (int i = 0; i < Math.Floor(n * 1.5) -1; i++)
            {
                for (int k = 0; k<n; k++)
                {
                    if (k != n - 1)
                    {
                        arrStripe[k] = arrStripe[k + 1];
                        Console.Write(arrStripe[k]);
                    }
                    else
                    {
                        arrStripe[n - 1] = (arrStripe[n - 3] == arrStripe[n - 2] ? '#' : '.');
                        Console.Write(arrStripe[k]);
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
