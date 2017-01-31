using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int[] numArray = new int[int.Parse(Console.ReadLine())];
            for(int i = 0; i<numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }
            for(int i = numArray.Length-1; i>=0; i--)
            {
                Console.Write("{0}{1}", numArray[i], i!=0 ? " ":"\n");
            }
        }
    }
}
