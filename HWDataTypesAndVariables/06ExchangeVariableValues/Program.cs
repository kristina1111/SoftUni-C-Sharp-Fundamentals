using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:\na = {0}\nb = {1}", first, second);
            int tempFirst = first;
            first = second;
            second = tempFirst;
            Console.WriteLine("After:\na = {0}\nb = {1}", first, second);
        }
    }
}
