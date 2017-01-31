using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04MultiplyBigNumbers
{
    class MultiplyBigNumbers
    {
        static void Main(string[] args)
        {
            string num1 = "000000" + Console.ReadLine();
            int numToMultiply = int.Parse(Console.ReadLine());
            string num2 = num1;
            if (numToMultiply ==0)
            {
                num2 = "0";
                Console.WriteLine(num2);
            }
            else if(numToMultiply>1)
            {
                while (numToMultiply > 1)
                {
                    int numRes = 0;
                    int onMind = 0;
                    StringBuilder sb = new StringBuilder();
                    for (int i = num1.Length - 1; i >= 0; i--)
                    {
                        numRes = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString()) + onMind;
                        sb.Insert(0, numRes % 10);
                        onMind = numRes / 10;
                    }
                    string result = sb.ToString();
                    num2 = result;
                    numToMultiply--;
                }
                Console.WriteLine(num2.TrimStart('0'));
            }
            else
            {
                Console.WriteLine(num2.TrimStart('0'));
            }
            
        }
    }
}
