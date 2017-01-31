using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SumMinMaxAverage
{
    class SumMinMaxAverage
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double[] numArr = new double[num];
            for(int i =0; i<num; i++)
            {
                numArr[i] = double.Parse(Console.ReadLine());
            }
            double sum = numArr.Sum();
            Console.WriteLine("Sum = {0}", sum);

            double min = numArr.Min();
            Console.WriteLine("Min = {0}", min);

            double max = numArr.Max();
            Console.WriteLine("Max = {0}", max);

            double average = numArr.Average();
            Console.WriteLine("Average = {0}", average);
        }
    }
}
