using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E09EncryptedMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string smbl = Console.ReadLine();
            int[] arr = new int[input.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = input[i] % 10;
            }
            //List<int> listDecr = new List<int>();
            string Nums = default(string);
            int num = 0;
            string numP = default(string);
            if(arr.Length==1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if(!(arr[i]%2==0 || arr[i]==0))
                    {
                        if (i == 0)
                        {
                            num = arr[i] + arr[i + 1];
                            Nums = Nums + num;
                        }
                        else if (i == arr.Length - 1)
                        {
                            num = arr[i] + arr[i - 1];
                            Nums = Nums + num;
                        }
                        else
                        {
                            num = arr[i] + arr[i - 1] + arr[i + 1];
                            Nums = Nums + num;
                        }
                    }
                    else
                    {
                        num = arr[i] * arr[i];
                        Nums = Nums + num;
                    }
                    
                }
                if (smbl == "/")
                {
                    //listDecr.Reverse();
                    for (int row = Nums.Length - 1; row >= 0; row--)
                    {
                        for (int col = 0; col < Nums.Length; col++)
                        {
                            if (col == row)
                            {
                                Console.Write(Nums[row] + " ");
                            }
                            else
                            {
                                Console.Write(0 + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int row = 0; row < Nums.Length; row++)
                    {
                        for (int col = 0; col < Nums.Length; col++)
                        {
                            if (col == row)
                            {
                                Console.Write(Nums[row] + " ");
                            }
                            else
                            {
                                Console.Write(0 + " ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            
        }
    }
}
