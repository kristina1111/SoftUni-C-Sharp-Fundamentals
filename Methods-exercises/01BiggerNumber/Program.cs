using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a,b));
        }

        static int GetMax(int a, int b)
        {
            if(a>b)
            {
                return a;
            }
            else if(a<b)
            {
                return b;
            }
            return a;
        }
    }
}
