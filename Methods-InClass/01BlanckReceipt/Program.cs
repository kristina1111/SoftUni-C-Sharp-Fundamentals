using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01BlanckReceipt
{
    class Program
    {
        static void Main()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        private static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }
        private static void PrintBody()
        {
            Console.Write("Charged to");
            Console.WriteLine(new string('_', 20));
            Console.Write("Received by");
            Console.WriteLine(new string('_', 19));
        }
        private static void PrintFooter()
        {
            Console.WriteLine(new string('-', 30));
            Console.WriteLine("\u00a9" + " "+ "SoftUni");
        }
    }
}
