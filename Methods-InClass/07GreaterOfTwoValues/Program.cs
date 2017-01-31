using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            if(type == "int")
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(num1, num2)); 
            }
            else if(type == "char")
            {
                char char1 = Console.ReadLine()[0];
                char char2 = Console.ReadLine()[0];
                Console.WriteLine(GetMax(char1, char2));
            }
            else if(type =="string")
            {
                string string1 = Console.ReadLine();
                string string2 = Console.ReadLine();
                Console.WriteLine(GetMax(string1, string2));
            }
        }

        private static int GetMax(int num1, int num2)
        {
            if(num1>num2)
            {
                return num1;
            }
            return num2;
        }

        private static char GetMax(char char1, char char2)
        {
            if (char1 > char2)
            {
                return char1;
            }
            return char2;
        }

        private static string GetMax(string string1, string string2)
        {
            int maxString = string1.CompareTo(string2);
            if(maxString==1)
            {
                return string1;
            }
            return string2;
        }
    }
}
