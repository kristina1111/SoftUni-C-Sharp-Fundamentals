using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04OperationsBetwenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            char smbl = char.Parse(Console.ReadLine());
            double result = default(double);
            
            if(n2==0 && ( smbl=='/' || smbl=='%'))
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else
            {
                switch (smbl)
                {
                    case '+': result = n1 + n2; break;
                    case '-': result = n1 - n2; break;
                    case '*': result = n1 * n2; break;
                    case '/': result = n1 / n2; break;
                    case '%': result = n1 % n2; break;
                }
                if(smbl=='/')
                {
                    Console.WriteLine("{0} {1} {2} = {3:f2}", n1, smbl, n2, result);
                }
                else if(smbl=='%')
                {
                    Console.WriteLine("{0} {1} {2} = {3}", n1, smbl, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - {4}", n1, smbl, n2, result, (result % 2 == 0 ? "even" : "odd"));
                }
            }
        }
    }
}
