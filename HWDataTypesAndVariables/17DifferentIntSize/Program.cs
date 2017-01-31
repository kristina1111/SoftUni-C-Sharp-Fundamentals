using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17DifferentIntSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            try
            {
                long num = long.Parse(input);
                if(num==0)
                {
                    Console.WriteLine("{0} can fit in:\n* sbyte\n* byte\n* short\n* ushort\n* int\n* uint\n* long", num);
                }
                else
                {
                    Console.WriteLine("{0} can fit in:", num);
                    
                    if(num>=sbyte.MinValue && num<=sbyte.MaxValue)
                    {
                        Console.WriteLine("* sbyte");
                    }
                    if(num >= byte.MinValue && num <= byte.MaxValue)
                    {
                        Console.WriteLine("* byte");
                    }
                    if (num >= short.MinValue && num <= short.MaxValue)
                    {
                        Console.WriteLine("* short");
                    }
                    if (num >= ushort.MinValue && num <= ushort.MaxValue)
                    {
                        Console.WriteLine("* ushort");
                    }
                    if (num >= int.MinValue && num <= int.MaxValue)
                    {
                        Console.WriteLine("* int");
                    }
                    if (num >= uint.MinValue && num <= uint.MaxValue)
                    {
                        Console.WriteLine("* uint");
                    }
                    if (num >= long.MinValue && num <= long.MaxValue)
                    {
                        Console.WriteLine("* long");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
