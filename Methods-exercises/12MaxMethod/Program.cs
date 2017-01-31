using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());
            int theGreatestNum = GetMax(GetMax(input1, input2), input3);
            Console.WriteLine(theGreatestNum);
        }
        static int GetMax(int num1, int num2)
        {
            if(num1>num2)
            {
                return num1;
            }
            return num2;
        }
    }
}
