using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DivideBy7and3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            //bool rslt = (num % 7 == 0) && (num % 5 == 0);
            Console.WriteLine((num % 7 == 0) && (num % 5 == 0));
        }
    }
}
