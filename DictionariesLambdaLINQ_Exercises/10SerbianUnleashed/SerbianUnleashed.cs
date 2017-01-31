using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10SerbianUnleashed
{
    class SerbianUnleashed
    {
        static void Main(string[] args)
        {
            string pattern = @"(\w+.\w+|\w+.\w+.\w+) @(\w+|\w+.\w+|\w+.\w+.\w+) (\d+) (\d+)";
            Regex rgx = new Regex(pattern);
            string command = Console.ReadLine();
            List<City> ListOfCities = new List<City>();
            while (!command.ToLower().Equals("end"))
            {
                bool containsValidInput = rgx.IsMatch(command);
                if (containsValidInput)
                {
                    Match match = rgx.Match(command);
                    City newCity = new City() { Name = match.Groups[2].ToString() };
                    if (ListOfCities.Any(c => c.Name.Equals(newCity.Name))) //first check if some of the items in listOfCities has a name like in the command
                    {// then check if the ListOfsingers dictionary of the item with name like in the newCity, contains suck singer;
                        if (ListOfCities.First(c => c.Name.Equals(newCity.Name)).singerList.ContainsKey(match.Groups[1].ToString()))
                        {// if it does, then add to the value the product of number of tickets multiplied by their price
                            ListOfCities.First(c => c.Name.Equals(newCity.Name)).singerList[match.Groups[1].ToString()] += double.Parse(match.Groups[3].ToString()) * double.Parse(match.Groups[4].ToString());
                        }
                        else
                        {// if the dictionary doesn't contain such singer, add it to the dictionary
                            ListOfCities.First(c => c.Name.Equals(newCity.Name)).singerList.Add(match.Groups[1].ToString(), double.Parse(match.Groups[3].ToString()) * double.Parse(match.Groups[4].ToString()));
                        }
                    }
                    else
                    {// add the info about the number of tickets multiplied by their price to the newCity
                        newCity.singerList.Add(match.Groups[1].ToString(), double.Parse(match.Groups[3].ToString()) * double.Parse(match.Groups[4].ToString()));
                        // then add the newCity to the ListOfCities
                        ListOfCities.Add(newCity);
                    }
                }
                command = Console.ReadLine();
            }
            foreach (City c in ListOfCities)
            {
                Console.WriteLine(c.Name);
                foreach (var s in c.singerList.OrderByDescending(v => v.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", s.Key, s.Value);
                }
            }

        }
    }
    public class City
    {
        public string Name { get; set; }
        public Dictionary<string, double> singerList { get; set; }
        public City()
        {
            singerList = new Dictionary<string, double>();
        }
    }
}
