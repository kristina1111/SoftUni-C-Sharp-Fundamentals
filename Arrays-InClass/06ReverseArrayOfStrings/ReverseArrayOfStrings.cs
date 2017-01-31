using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(' ').ToArray();
            string wordToReplace = "";
            for(int i = 0; i<= (stringArr.Length-1)/2; i++)
            {
                wordToReplace = stringArr[i];
                stringArr[i] = stringArr[stringArr.Length - 1 - i];
                stringArr[stringArr.Length - 1 - i] = wordToReplace;
            }
            for(int i = 0; i<stringArr.Length; i++)
            {
                Console.Write("{0}{1}", stringArr[i], i!=stringArr.Length-1 ? " ": "\n");
            }
        }
    }
}
