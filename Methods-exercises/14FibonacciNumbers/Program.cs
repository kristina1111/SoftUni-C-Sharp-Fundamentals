using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNum(num));
        }
        static int GetFibonacciNum(int num)
        {
            int firstNum = 1;
            int secNum = 1;
            int fibonacciNum = firstNum;

            for(int i = 2; i<=num; i++)
            {
                fibonacciNum = firstNum + secNum;
                firstNum = secNum;
                secNum = fibonacciNum;
            }
            return fibonacciNum;
        }
    }
}
