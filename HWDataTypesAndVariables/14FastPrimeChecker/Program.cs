using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool[] numArr = new bool[num+1];
            for(int i = 2; i<num+1; i++)
            {
                if(numArr[i] == false)
                {
                    int cnt = 2;
                    while(cnt*i<num+1)
                    {
                        numArr[cnt * i] = true;
                        cnt++;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, !numArr[i]);
            }
        }
    }
}
