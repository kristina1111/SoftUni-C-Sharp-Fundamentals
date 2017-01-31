using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace E19Petar_sGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());
            string rplstr = Console.ReadLine();
            decimal sum = default(decimal);
            for(ulong i = num1; i<num2; i++)
            {
                if(i%5==0)
                {
                    sum += i;
                }
                else
                {
                    sum += i % 5;
                }
            }
            string numString = sum.ToString();
            string[] numArr = new string[numString.Length];

            if(sum%2==0)
            {
                numArr[0] = rplstr;
                char checkCh = numString[0];
                for(int i = 1; i<numString.Length; i++)
                {
                    if(numString[i] == checkCh)
                    {
                        numArr[i] = rplstr;
                    }
                    else
                    {
                        numArr[i] = (new string(numString[i], 1));
                    }
                }
            }
            else
            {
                numArr[numString.Length - 1] = rplstr;
                char checkCh = numString[numString.Length-1];
                for(int i = numString.Length-1; i>=0; i--)
                {
                    if (numString[i] == checkCh)
                    {
                        numArr[i] = rplstr;
                    }
                    else
                    {
                        numArr[i] = (new string(numString[i], 1));
                    }
                }
            }
            foreach(string i in numArr)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
    }
}
