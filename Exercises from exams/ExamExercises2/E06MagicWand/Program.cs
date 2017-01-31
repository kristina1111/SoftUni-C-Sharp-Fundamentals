using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06MagicWand
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte n = sbyte.Parse(Console.ReadLine());
            Console.WriteLine("{0}*{0}", new string('.', (3 * n + 2) / 2));
            sbyte left = (sbyte)((3 * n + 2) / 2);
            sbyte right = (sbyte)((3 * n + 2) / 2 + 2);
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                for (int k = 1; k <= (3 * n + 2); k++)
                {
                    if (k == left || k == right)
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
            Console.WriteLine("{0}{1}{0}", new string('*', n), new string('.', n + 2));
            left = 1;
            right = (sbyte)(3 * n + 2);
            sbyte leftR = (sbyte)(n + 1);
            sbyte rightL = (sbyte)(2 * n + 2);
            sbyte midR = (sbyte)(2 * n + 2);
            sbyte midL = (sbyte)(n + 1);
            for (int i = 1; i <= n; i++)
            {
                if (i <= n / 2)
                {
                    left++;
                    right--;
                }
                else if (i > n / 2 && i < n)
                {
                    left--;
                    right++;
                    leftR--;
                    rightL++;

                }
                for (int k = 1; k <= (3 * n + 2); k++)
                {
                    if (i <= n / 2)
                    {
                        if (k == left || k == right)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    else if (i > n / 2 && i < n)
                    {
                        if (k == left || k == right || k == leftR || k == rightL || k == midL || k == midR)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }

                    }
                    else if (i == n)
                    {
                        if ((k >= left && k < leftR) || k == midL || k == midR || (k > rightL && k <= right))
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                }
                
                Console.WriteLine();

            }
            for(int i =1; i<=n;i++)
            {
                Console.WriteLine("{0}*{0}*{0}", new string('.', n));
            }
            Console.WriteLine("{0}*{1}*{0}", new string('.', n), new string('*', n));

        }
    }
}
