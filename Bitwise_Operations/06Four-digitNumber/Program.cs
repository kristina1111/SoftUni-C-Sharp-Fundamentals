using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Four_digitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] nums = new char[4];
            int sum = 0;
            for(int i = 0; i<4; i++)
            {
                nums[i] = input[i];
                sum += int.Parse(nums[i].ToString());
            }
            Console.WriteLine(sum);
            Array.Reverse(nums);
            Console.WriteLine(nums);

            Array.Reverse(nums);
            Console.Write(nums[3]);
            for (int i =0; i<3; i++)
            {
                Console.Write(nums[i]);
            }
            Console.WriteLine();

        }
    }
}
