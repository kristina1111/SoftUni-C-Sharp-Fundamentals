using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ThirdDigit7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()) / 100;
            Console.WriteLine(num % 10 == 7);
            
        }
    }
}
