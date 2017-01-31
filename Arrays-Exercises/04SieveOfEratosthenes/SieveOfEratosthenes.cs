using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool[] array = new bool[number + 1];
            array[0] = array[1] = true;
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == false)
                {
                    Console.Write("{0} ", Array.IndexOf(array, false, i));

                    for (int k = i + i; k < array.Length; k += i)
                    {
                        array[k] = true;
                    }
                }
            }

        }
    }
}
