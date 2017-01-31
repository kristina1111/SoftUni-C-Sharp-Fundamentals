using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E03FootbalLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();


            List<Country> listOfCountries = new List<Country>();

            int cnt = 0;
            while (cnt < key.Length)
            {
                if (key[cnt] == '.' || key[cnt] == '?' || key[cnt] == '*' || key[cnt] == '#' || key[cnt] == '!' || key[cnt] == ' ' || key[cnt] == '$' || key[cnt] == '(' || key[cnt] == ')' || key[cnt] == '[' || key[cnt] == ']')
                {
                    key = key.Insert(cnt, "\\");
                    cnt++;
                }
                cnt++;
            }
            string pattern = @"" + key + "";
            string replacement = "??";
            Regex regex = new Regex(pattern);

            string ptrnForCntryName = @"\b(?<=\?\?)([a-zA-Z]*)(?=\?\?)\b"; //\b
            //string ptrnForCntryName = @"(?<=" + key + @")([a-zA-Z]*)(?=" + key + @")";
            string ptrnForScore = @"(([\d]+):([\d]+))(?=$)";
            Regex rgxCountryName = new Regex(ptrnForCntryName);
            Regex rgxScores = new Regex(ptrnForScore);

            string inputInfo = Console.ReadLine();
            while (!inputInfo.ToUpper().Equals("FINAL"))
            {
                inputInfo = regex.Replace(inputInfo, replacement) ;
                MatchCollection countryMatches = rgxCountryName.Matches(inputInfo);
                MatchCollection goalMatches = rgxScores.Matches(inputInfo);
                Country newCountry1 = new Country();
                newCountry1.Name = new string(countryMatches[0].ToString().ToUpper().ToCharArray().Reverse().ToArray());
                Country newCountry2 = new Country();
                newCountry2.Name = new string(countryMatches[1].ToString().ToUpper().ToCharArray().Reverse().ToArray());
                foreach (Match m in goalMatches)
                {
                    newCountry1.Goals = double.Parse(m.Groups[2].ToString());
                    newCountry2.Goals = double.Parse(m.Groups[3].ToString());
                }

                if (newCountry1.Goals > newCountry2.Goals)
                {
                    newCountry1.Score = 3;
                }
                else if (newCountry1.Goals < newCountry2.Goals)
                {
                    newCountry2.Score = 3;
                }
                else
                {
                    newCountry1.Score = 1;
                    newCountry2.Score = 1;
                }

                if (listOfCountries.Any(c => c.Name.Equals(newCountry1.Name)))
                {
                    listOfCountries.First(c => c.Name.Equals(newCountry1.Name)).Goals += newCountry1.Goals;
                    listOfCountries.First(c => c.Name.Equals(newCountry1.Name)).Score += newCountry1.Score;
                }
                else
                {
                    listOfCountries.Add(newCountry1);
                }

                if (listOfCountries.Any(c => c.Name.Equals(newCountry2.Name)))
                {
                    listOfCountries.First(c => c.Name.Equals(newCountry2.Name)).Goals += newCountry2.Goals;
                    listOfCountries.First(c => c.Name.Equals(newCountry2.Name)).Score += newCountry2.Score;
                }
                else
                {
                    listOfCountries.Add(newCountry2);
                }

                inputInfo = Console.ReadLine();
            }

            listOfCountries = listOfCountries.OrderByDescending(c => c.Score).ThenBy(c => c.Name).ToList();
            Console.WriteLine("League standings:");
            for (int i = 0; i < listOfCountries.Count; i++)
            {
                Console.WriteLine("{0}. {1} {2}", i + 1, listOfCountries[i].Name, listOfCountries[i].Score);
            }
            Console.WriteLine("Top 3 scored goals:");
            listOfCountries = listOfCountries.OrderByDescending(c => c.Goals).ThenBy(c => c.Name).ToList();
            for (int i = 0; i < (Math.Min(3, listOfCountries.Count)); i++)
            {
                Console.WriteLine("- {0} -> {1}", listOfCountries[i].Name, listOfCountries[i].Goals);
            }
        }
    }
    class Country
    {
        public string Name { get; set; }
        public double Goals { get; set; }
        public int Score { get; set; }
    }
}
