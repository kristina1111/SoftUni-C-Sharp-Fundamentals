using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07PlaidTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            byte size = byte.Parse(Console.ReadLine());
            char bcgrndSym = char.Parse(Console.ReadLine());
            char rhombusSym = char.Parse(Console.ReadLine());

            //Upper Rhombus
            //upper part
            int leftL = size + 1;
            int rightL = size + 1;
            int leftR = size*3 + 1;
            int rightR = size*3 + 1;

            for(int i = 1; i<=size+1; i++)
            {
                for(int k = 1; k<=size*4+1; k++)
                {
                    if(leftL == k || leftR==k || rightL == k || rightR == k)
                    {
                        Console.Write(rhombusSym);
                    }
                    else
                    {
                        Console.Write(bcgrndSym);
                    }
                }
                leftL--;
                leftR--;
                rightR++;
                rightL++;
                Console.WriteLine();
            }

            //down part
            leftL = 2;
            rightL = size*2;
            leftR = size * 2 +2;
            rightR = size * 4;

            for(int i = 1; i<=size; i++)
            {
                for (int k = 1; k <= size * 4 + 1; k++)
                {
                    if (leftL == k || leftR == k || rightL == k || rightR == k)
                    {
                        Console.Write(rhombusSym);
                    }
                    else
                    {
                        Console.Write(bcgrndSym);
                    }
                }
                leftL++;
                rightL--;
                leftR++;
                rightR--;
                Console.WriteLine();
            }

            //Down Rhombus
            //upper part
            leftL = size;
            rightL = size + 2;
            leftR = size * 3;
            rightR = size * 3 + 2;

            for (int i = 2; i <= size + 1; i++)
            {
                for (int k = 1; k <= size * 4 + 1; k++)
                {
                    if (leftL == k || leftR == k || rightL == k || rightR == k)
                    {
                        Console.Write(rhombusSym);
                    }
                    else
                    {
                        Console.Write(bcgrndSym);
                    }
                }
                leftL--;
                leftR--;
                rightR++;
                rightL++;
                Console.WriteLine();
            }

            //down part
            leftL = 2;
            rightL = size * 2;
            leftR = size * 2 + 2;
            rightR = size * 4;

            for (int i = 1; i <= size; i++)
            {
                for (int k = 1; k <= size * 4 + 1; k++)
                {
                    if (leftL == k || leftR == k || rightL == k || rightR == k)
                    {
                        Console.Write(rhombusSym);
                    }
                    else
                    {
                        Console.Write(bcgrndSym);
                    }
                }
                leftL++;
                rightL--;
                leftR++;
                rightR--;
                Console.WriteLine();
            }

        }
    }
}
