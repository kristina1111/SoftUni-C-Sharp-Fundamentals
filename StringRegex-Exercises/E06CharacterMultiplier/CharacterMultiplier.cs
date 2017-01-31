using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace E06CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            BigInteger resultSum = 0;
            if (input.Length > 1)
            {
                string input1 = input[0];
                string input2 = input[1];
                if (input1.Length < input2.Length)
                {
                    string temp = input1;
                    input1 = input2;
                    input2 = temp;
                }
                int cnt = 0;
                
                for (int i = 0; i <= input1.Length - 1; i++)
                {
                    double multiplication = 0;
                    if (cnt<input2.Length)
                    {
                        multiplication = (double)input1[i] * (double)input2[cnt];
                        cnt++;
                    }
                    else
                    {
                        multiplication = (double)input1[i];
                    }

                    resultSum += (BigInteger)multiplication;
                }
            }
            else if(input.Length == 1)
            {
                resultSum = input[0].Select(c => (int)c).Sum();
            }

            Console.WriteLine(resultSum);
        }
    }
}
