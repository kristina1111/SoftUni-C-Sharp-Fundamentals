using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace E18Sunlight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{0}", new string('.', n*3/2));
            int left = 1;
            int right = n * 3 - 2;
            int mid = n * 3 / 2;
            for (int i = 0; i<n-1; i++)
            {
                for(int k =0; k<n*3; k++)
                {
                    if(k==left || k==right || k==mid)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                left++;
                right--;
            }

            for(int i=0; i<n; i++)
            {
                if(i==n/2)
                {
                    Console.WriteLine(new string('*', n*3));
                }
                else
                {
                    Console.WriteLine("{0}{1}{0}", new string('.', n), new string('*', n));
                }
            }
            left = n - 1;
            right = n * 2;
            for(int i = 0; i<n-1; i++)
            {
                for(int k =0; k<n*3; k++)
                {
                    if (k == left || k == right || k == mid)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                left--;
                right++;
            }

            Console.WriteLine("{0}*{0}", new string('.', n * 3 / 2));
        }
    }
}
