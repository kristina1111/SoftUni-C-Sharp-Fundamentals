using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            for(int i = 232; i<=inputNum; i++)
            {
                //string numToCheck = i.ToString();

                //bool isThereOneEvenDigit = IsThereOneEvenDigit(i);
                ////if (!isThereOneEvenDigit)
                ////{
                ////    continue;
                ////}

                bool isPalindrome = IsPalindrome(i);
                //if (!isPalindrome)
                //{
                //    continue;
                //}

                bool IsDigitSumDiv7 = IsDigitSumDivBy7(i);
                //if (!IsDigitSumDiv7)
                //{
                //    continue;
                //} 

                if (isPalindrome && IsDigitSumDiv7)  //&& isThereOneEvenDigit
                {
                    Console.WriteLine(i);
                }
            }
            
        }

        //private static bool IsThereOneEvenDigit(int numToCheck)
        //{
        //    int num = numToCheck;
        //    while(num!=0)
        //    {
        //        //int num = int.Parse(numToCheck[i].ToString());
        //        if ((num % 10)%2 == 0)
        //        {
        //            return true;
        //            // break
        //        }
        //        num = num / 10;
        //    }
        //    return false;
        //}

        private static bool IsDigitSumDivBy7(int numToCheck)
        {
            int sumOfDigits = 0;
            int num = numToCheck;
            while(num!=0)
            {
                sumOfDigits += (num%10);
                num = num / 10;
            }
            if(sumOfDigits%7==0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPalindrome(int numToCheck)
        {
            string numString = numToCheck.ToString();
            bool isOneDigitEven = true;
            bool toCompare = true;
            //string toCompare = new string(numString.Reverse().ToArray());
            for (int i = numString.Length - 1; i >= 0; i--)
            {
                //toCompare += numString[i];
                if(numString[i]!=numString[numString.Length-1-i] && toCompare)
                {
                    toCompare = false;
                    return false;
                }

                if (isOneDigitEven)
                {
                    if (int.Parse(numString[i].ToString()) % 2 == 0)
                    {
                        isOneDigitEven = false;
                        //return true;
                    }
                }
            }
            if (toCompare && !isOneDigitEven) // && !isOneDigitEven
            {
                return true;
            }
            return false;
        }
    }
}
