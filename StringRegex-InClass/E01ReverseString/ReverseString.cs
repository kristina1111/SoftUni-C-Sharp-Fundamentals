using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = new string(input.ToCharArray().ToArray().Reverse().ToArray());
            Console.WriteLine(input);

            //for(int i = input.Length-1; i>=0; i--)
            //{
            //    Console.Write(input[i]);
            //}
            //Console.WriteLine();

        }
    }
}
