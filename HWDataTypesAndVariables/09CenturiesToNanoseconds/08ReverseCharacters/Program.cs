using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ReverseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] inputArr = new char[3];
            for(int i = 0; i<3; i++)
            {
                inputArr[i] = char.Parse(Console.ReadLine());
            }
            for(int i = 2; i>=0; i--)
            {
                Console.Write(inputArr[i]);
            }
            Console.WriteLine();
        }
    }
}
