using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05ArrayMatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\').ToArray();
            string[] newArr = new string[Math.Max(input[0].Length, input[1].Length)];
            string checker = (input[0].Length > input[1].Length ? input[0] : input[1]);
            string forCheck = (input[0].Length > input[1].Length ? input[1] : input[0]);
            int cnt = 0;
            if (input[2].ToLower()=="join")
            {
                for (int i = 0; i < checker.Length; i++)
                {
                    if(forCheck.Contains(checker[i]))
                    {
                        newArr[cnt] = checker[i].ToString();
                        cnt++;
                    }
                }
            }
            else if(input[2].ToLower() == "right exclude")
            {
                for(int i =0; i<input[0].Length; i++)
                {
                    if(!input[1].Contains(input[0][i]))
                    {
                        newArr[cnt] = checker[i].ToString();
                        cnt++;
                    }
                }
            }
            else if(input[2].ToLower() == "left exclude")
            {
                for(int i=0; i<input[1].Length; i++)
                {
                    if(!input[0].Contains(input[1][i]))
                    {
                        newArr[cnt] = checker[i].ToString();
                        cnt++;
                    }
                }
            }
            newArr = newArr.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Array.Sort(newArr, StringComparer.Ordinal);
            foreach(string i in newArr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
