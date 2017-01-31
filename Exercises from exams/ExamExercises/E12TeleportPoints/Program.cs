using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E12TheFootbalStatistition
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> first = Console.ReadLine().Split(' ').ToList();

            //string input = "  Arsenal   X  Liverpool ";
            //Console.WriteLine(input);
            //input = string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            //Console.WriteLine(input);


            decimal payment = decimal.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<string> teams = new List<string>();
            List<string> forSorting = new List<string>();
            List<int> result = new List<int>();
            int cntTeams = 0;

            while (input != "End of the league.")
            {
                cntTeams += 1;
                input = string.Join(" ", input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                string[] inputArr = input.Split(' ').ToArray();
                int cnt = 0;
                int cntOther = 0;
                bool isIn = false;
                if (inputArr[1] == "1")
                {
                    cnt = 0;
                    cntOther = 2;
                }
                else if (inputArr[1] == "2")
                {
                    cnt = 2;
                    cntOther = 0;
                }
                else if (inputArr[1] == "X")
                {
                    cnt = 0;
                    cntOther = 2;
                    isIn = true;
                }


                if (!teams.Contains(inputArr[cnt]) && !teams.Contains(inputArr[cntOther]))
                {
                    teams.Add(inputArr[cnt]);
                    teams.Add(inputArr[cntOther]);
                    result.Insert(teams.IndexOf(inputArr[cnt]), 0);
                    result.Insert(teams.IndexOf(inputArr[cntOther]), 0);
                    if (isIn)
                    {
                        result[teams.IndexOf(inputArr[cnt])] += 1;
                        result[teams.IndexOf(inputArr[cntOther])] += 1;
                    }
                    else
                    {
                        result[teams.IndexOf(inputArr[cnt])] += 3;
                        result[teams.IndexOf(inputArr[cntOther])] += 0;
                    }
                    
                }
                else if(teams.Contains(inputArr[cnt]) && teams.Contains(inputArr[cntOther]))
                {
                    if (isIn)
                    {
                        result[teams.IndexOf(inputArr[cnt])] += 1;
                        result[teams.IndexOf(inputArr[cntOther])] += 1;
                    }
                    else
                    {
                        result[teams.IndexOf(inputArr[cnt])] += 3;
                        result[teams.IndexOf(inputArr[cntOther])] += 0;
                    }
                }
                else
                {
                    if(teams.Contains(inputArr[cnt]))
                    {
                        teams.Add(inputArr[cntOther]);
                        result.Insert(teams.IndexOf(inputArr[cntOther]), 0);
                    }
                    else
                    {
                        teams.Add(inputArr[cnt]);
                        result.Insert(teams.IndexOf(inputArr[cnt]), 0);
                    }

                    if (isIn)
                    {
                        result[teams.IndexOf(inputArr[cnt])] += 1;
                        result[teams.IndexOf(inputArr[cntOther])] += 1;
                    }
                    else
                    {
                        result[teams.IndexOf(inputArr[cnt])] += 3;
                        result[teams.IndexOf(inputArr[cntOther])] += 0;
                    }
                }


                input = Console.ReadLine();
                
            }
            for (int i = 0; i<teams.Count; i++)
            {
                teams[i] = string.Concat(teams[i].Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
                forSorting.Add($"{teams[i]} - {(result[i] == default(int) ? 0 : result[i] )} points.");
            }


            payment = payment * 1.94m * cntTeams;
            Console.WriteLine("{0:f2}lv.", payment);

            forSorting.Sort();

            for (int i = 0; i<forSorting.Count; i++)
            {
                Console.WriteLine(forSorting[i]);
            }
            

        }
    }
}
