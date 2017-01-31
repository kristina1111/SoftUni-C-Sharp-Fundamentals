using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for(int i =1; i<=9;i++)
            {
                if(input%i!=0)
                {
                    continue;
                }
                else
                {
                    for(int j=1; j<=9; j++)
                    {
                        if(input%j!=0)
                        {
                            continue;
                        }
                        else
                        {
                            for(int k=1; k<=9; k++)
                            {
                                if(input%k!=0)
                                {
                                    continue;
                                }
                                else
                                {
                                    for(int l=1; l<=9; l++)
                                    {
                                        if(input%l!=0)
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.Write(""+i+j+k+l+" ");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
