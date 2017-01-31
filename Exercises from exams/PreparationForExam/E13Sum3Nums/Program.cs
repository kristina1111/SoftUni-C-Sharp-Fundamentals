using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E13Sum3Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNums = new int[3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                arrNums[i] = int.Parse(Console.ReadLine());
                sum += arrNums[i];
            }
            sum -= arrNums.Max();
            if (sum == arrNums.Max())
            {
                int frst = 0;
                int scnd = 0;
                bool isIn1 = true;
                bool isIn2 = false;
                for (int i = 0; i < 3; i++)
                {
                    if (Array.IndexOf(arrNums, arrNums.Max()) != i)
                    {
                        if(isIn1)
                        {
                            frst = arrNums[i];
                            isIn2 = true;
                            isIn1 = false;
                            continue;
                        }
                        if (isIn2)
                        {
                            scnd = arrNums[i];
                        }

                    }
                }

                Console.WriteLine("{0} + {1} = {2}", (frst<scnd ? frst : scnd), (frst < scnd ? scnd : frst), sum);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
