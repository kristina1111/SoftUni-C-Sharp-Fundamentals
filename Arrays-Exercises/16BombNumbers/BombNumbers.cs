using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16BombNumbers
{
    class BombNumbers
    {
        static void Main(string[] args)
        {
            string[] numArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] command = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            while(numArray.Contains(command[0]))
            {
                int positon = Array.IndexOf(numArray, command[0]);
                int bombPower = int.Parse(command[1]);
                numArray = GetArrayWithoutLeftBombed(numArray, bombPower, positon);
                numArray = GetArrayWithoutRightBombed(numArray, bombPower, positon);
            }
            int sum = GetSum(numArray);
            Console.WriteLine(sum);

        }
        static string[] GetArrayWithoutLeftBombed(string[] array, int bombPower, int position)
        {
            for(int i = position; i>=Math.Max(0, position-bombPower); i--)
            {
                array[i] = "";
            }
            return array;
        }
        static string[] GetArrayWithoutRightBombed(string[] array, int bombPower, int position)
        {
            for(int i = position+1; i<Math.Min(position+1+bombPower, array.Length); i++)
            {
                array[i] = "";
            }
            return array;
        }
        static int GetSum(string[] array)
        {
            int sum = 0;
            for(int i = 0; i<array.Length; i++)
            {
                if(array[i]!="")
                {
                    sum += int.Parse(array[i]);
                }
            }
            return sum;
        }
    }
}
