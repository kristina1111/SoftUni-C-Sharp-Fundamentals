using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11BasketBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[2];
            names[0] = Console.ReadLine();
            names[1] = (names[0] == "Simeon" ? "Nakov" : "Simeon");
            int[] score = new int[2];
            int n = int.Parse(Console.ReadLine());
            bool isIn = true;
            for (int i = 0; i < n; i++)
            {
                string frst = names[i % names.Length];
                string scnd = (frst == "Simeon" ? "Nakov" : "Simeon");
                int tryScore1 = int.Parse(Console.ReadLine());
                string result1 = Console.ReadLine();
                if(result1 == "success")
                {
                    if(score[Array.IndexOf(names, frst)] + tryScore1 <500 )
                    {
                        score[Array.IndexOf(names, frst)] += tryScore1;
                    }
                    else if(score[Array.IndexOf(names, frst)] + tryScore1 == 500)
                    {
                        score[Array.IndexOf(names, frst)] += tryScore1;
                        Console.WriteLine(frst);
                        Console.WriteLine(i+1);
                        Console.WriteLine(score[Array.IndexOf(names, scnd)]);
                        isIn = false;
                        break;
                        
                    }
                }
                int tryScore2 = int.Parse(Console.ReadLine());
                string result2 = Console.ReadLine();
                if (result2 == "success")
                {
                    if (score[Array.IndexOf(names, scnd)] + tryScore2 < 500)
                    {
                        score[Array.IndexOf(names, scnd)] += tryScore2;
                    }
                    else if (score[Array.IndexOf(names, scnd)] + tryScore2 == 500)
                    {
                        score[Array.IndexOf(names, scnd)] += tryScore2;
                        Console.WriteLine(scnd);
                        Console.WriteLine(i+1);
                        Console.WriteLine(score[Array.IndexOf(names, frst)]);
                        isIn = false;
                        break; 
                    }
                }

            }
            if(isIn)
            {
                if(score[0]==score[1])
                {
                    Console.WriteLine("DRAW\n{0}", score[0]);
                }
                else
                {
                    Console.WriteLine("{0}\n{1}", names[Array.IndexOf(score, score.Max())], Math.Abs(score[0] - score[1])); 
                }
            }
        }
    }
}
