using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                int n = int.Parse(Console.ReadLine());
                bool[] primeArr = new bool[n + 1];
                primeArr[0] = primeArr[1] = true;
                for (int i = 2; i <= n; i++)
                {
                    if (primeArr[i] == false)
                    {
                        Console.WriteLine(Array.IndexOf(primeArr, false, i));
                        for (int k = 2*i; k <= n; k+=i)
                        {
                            primeArr[k] = true;
                        }
                    }
                }
            }
        }
    }
}
