using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E15Increasing4Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            if (n2 - n1 < 3)
            {
                Console.WriteLine("No");
            }
            else if(n2-n1 == 3)
            {
                Console.WriteLine("{0} {1} {2} {3}",n1, n1+1, n1+2, n2);
            }
            else
            {
                int adder = ((n2 - n1) % 2 == 0 ? (n2 - n1) / 2 - 1 : (n2 - n1) / 2); 
                int[] arr = new int[4];
                for (int i = n1; i <= n2; i++)
                {
                    arr[0] = i;
                    for (int j = n1 + 1; j <= n2; j++)
                    {
                        arr[1] = j;
                        for (int k = n1 + 2; k <= n2; k++)
                        {
                            arr[2] = k;
                            for (int l = n1 + 3; l <= n2; l++)
                            {
                                arr[3] = l;
                                if (arr.Distinct().Count() == arr.Length && (n1 <= i && i<j && j<k && k<l && l<=n2))
                                {
                                    Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
