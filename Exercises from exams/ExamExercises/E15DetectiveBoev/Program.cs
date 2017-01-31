using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E15DetectiveBoev
{
    class Program
    {
        static void Main(string[] args)
        {
            string scrWrd = Console.ReadLine();
            string encrMsg = Console.ReadLine();
            int sum = 0;
            int mask = 0;
            foreach (char i in scrWrd)
            {
                sum += i;
            }
            while (sum != 0)
            {
                mask += sum % 10;
                sum /= 10;
                if(sum==0 && mask>9)
                {
                    sum = mask;
                    mask = 0;
                }
            }
            string dcdMsg = default(string);
            foreach(char i in encrMsg)
            {
                int temp = default(int);
                if(i%mask==0)
                {
                    temp = i + mask;
                }
                else
                {
                    temp = i - mask;
                }
                dcdMsg += (char)temp;
            }
            Console.WriteLine(new string(dcdMsg.Reverse().ToArray()));
        }
    }
}
