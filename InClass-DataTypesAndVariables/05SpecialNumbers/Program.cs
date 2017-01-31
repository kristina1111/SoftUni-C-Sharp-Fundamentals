using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool[] numArr = new bool[num];
            for (int i = 5; i <= num; i++)
            {
                int numCheck = i;
                int sum = 0;
                while (numCheck != 0)
                {
                    sum += numCheck % 10;
                    numCheck /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    numArr[i - 1] = true;
                }
            }

            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine("{0} -> {1}", i+1, numArr[i]);
            }
        }
    }
}
