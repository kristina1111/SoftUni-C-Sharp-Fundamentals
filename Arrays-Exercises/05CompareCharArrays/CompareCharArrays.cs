using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] array1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] array2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            if (array1.Length > array2.Length)
            {
                char[] arrayToSave = array2;
                array2 = array1;
                array1 = arrayToSave;
            }
            bool isPrinted = true;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < array2[i])
                {
                    Console.WriteLine(string.Join("", array1));
                    Console.WriteLine(string.Join("", array2));
                    isPrinted = false;
                    break;
                }
                else if (array1[i] > array2[i])
                {
                    Console.WriteLine(string.Join("", array2));
                    Console.WriteLine(string.Join("", array1));
                    isPrinted = false;
                    break;
                }
            }
            if (isPrinted)
            {
                Console.WriteLine(string.Join("", array1));
                Console.WriteLine(string.Join("", array2));
            }
        }
    }
}
