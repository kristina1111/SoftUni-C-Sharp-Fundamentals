using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06NumberCalculation
{
    class Program
    {
        //Not done!!!!!

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        }
        static int GetMinimum(int[] input)
        {
            int min = input[0];
            for(int i = 1; i<input.Length; i++)
            {
                if(min>input[i])
                {
                    min = input[i];
                }
            }
            return min;
        }

        static int GetMaximum(int[] input)
        {
            int max = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                if (max < input[i])
                {
                    max = input[i];
                }
            }
            return max;
        }
    }
}
