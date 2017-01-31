using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(code, 16));
        }
    }
}
