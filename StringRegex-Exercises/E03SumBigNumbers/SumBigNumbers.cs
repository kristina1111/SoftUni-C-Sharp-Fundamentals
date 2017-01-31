using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string num1 = "00"+ Console.ReadLine();
            string num2 = "00" + Console.ReadLine();
            if(num1.Length!=num2.Length)
            {
                if(num1.Length<num2.Length)
                {
                    string temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
                StringBuilder sbl = new StringBuilder();
                for(int i=num1.Length-1; i>=0; i--)
                {
                    if (i < num2.Length)
                    {
                        sbl.Append(num2[num2.Length - 1-i]);
                    }
                    else
                    {
                        sbl.Append("0");
                    }
                }
                num2 = sbl.ToString();
            }

            int numRes = 0;
            int onMind = 0;
            StringBuilder sb = new StringBuilder();
            for(int i =num1.Length-1; i>=0; i--)
            {
                numRes = int.Parse(num1[i].ToString()) + int.Parse(num2[i].ToString())+onMind;
                sb.Insert(0, numRes % 10);
                onMind = numRes / 10;
            }
            string result = sb.ToString().TrimStart('0');
            Console.WriteLine(result);

        }
    }
}
