using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E14IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int cntr = 0;
            List<int> cnt = new List<int>();
            for(int i = 0; i<n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for(int i =0;i<n-1; i++)
            {
                if(arr[i] < arr[i+1])
                {
                    cntr++;
                    if(i==n-2)
                    {
                        cntr++;
                        cnt.Add(cntr);
                    }
                }
                else
                {
                    cntr++;
                    cnt.Add(cntr);
                    cntr = 0;
                } 
            }
            if (n==0)
            {
                Console.WriteLine(0);
            }
            else if(n==1)
            {
                Console.WriteLine(1);
            }
            else
            {
                Console.WriteLine(cnt.Max());
            }
            
        }
    }
}
