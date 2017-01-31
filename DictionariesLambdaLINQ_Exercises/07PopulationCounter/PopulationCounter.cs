using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Country> ListOfCountries = new List<Country>();  // create list of Countries;
            while(!command.Equals("report"))
            {
                string[] infoCommand = command.Split('|').ToArray();
                Country newCountry = new Country() { Name = infoCommand[1] };
                if(!ListOfCountries.Any(c=>c.Name==infoCommand[1])) // check if ListOfCountries contains  item with the name given in the command
                {// if it doesn't contain such item - add it to the list
                    // but firts add the country and the population in the dictionary of the newCountry
                    newCountry.CitiesAndNumPopulation.Add(infoCommand[0], double.Parse(infoCommand[2]));
                    // add the population of that city to the total population of the newCountry object
                    newCountry.NumPopulation = double.Parse(infoCommand[2]);
                    // then add it to the list
                    ListOfCountries.Add(newCountry);
                }
                else  // if the list contains such item
                {
                    // find that item and check if its dictionary doesn't contain such country
                    // first one iten in the list that satisfies the condition --> we take that item and for its dictionary we 
                    //                                                              chec if it ContainsKey the given city in the command
                    if(ListOfCountries.First(c=>c.Name == infoCommand[1]).CitiesAndNumPopulation.ContainsKey(infoCommand[0]))
                    {
                        // need to substract the number of population of that city which is already in the NumPopulation property
                        ListOfCountries.First(c => c.Name == infoCommand[1]).NumPopulation -= ListOfCountries.First(c => c.Name == infoCommand[0]).CitiesAndNumPopulation[infoCommand[0]];
                        // then add the new number of population from the command
                        ListOfCountries.First(c => c.Name == infoCommand[1]).NumPopulation += double.Parse(infoCommand[2]);
                        // then replace the old value in the dictionary with the new number of population
                        ListOfCountries.First(c => c.Name == infoCommand[1]).CitiesAndNumPopulation[infoCommand[0]] = double.Parse(infoCommand[2]);
                    }
                    else
                    {//if its dictionary doesn't contain such key, add the city to the dictionary
                        ListOfCountries.First(c => c.Name == infoCommand[1]).CitiesAndNumPopulation.Add(infoCommand[0], double.Parse(infoCommand[2]));
                        //then add the populaton of the added city to the NumPopulation property
                        ListOfCountries.First(c => c.Name == infoCommand[1]).NumPopulation += double.Parse(infoCommand[2]);
                    }
                }
                command = Console.ReadLine();
            }
            ListOfCountries = ListOfCountries.OrderByDescending(c => c.NumPopulation).ToList();
            for(int i =0;i<ListOfCountries.Count; i++)
            {
                ListOfCountries[i].CitiesAndNumPopulation = ListOfCountries[i].CitiesAndNumPopulation.OrderByDescending(c => c.Value).ToDictionary(x => x.Key, x => x.Value);
                Console.WriteLine("{0} (total population: {1})", ListOfCountries[i].Name, ListOfCountries[i].NumPopulation);
                foreach(var c in ListOfCountries[i].CitiesAndNumPopulation)
                {
                    Console.WriteLine("=>{0}: {1}", c.Key, c.Value);
                }
            }
        }
    }
    public class Country
    {
        public string Name { get; set; }
        public Dictionary<string, double> CitiesAndNumPopulation { get; set; }
        public Country()
        {
            CitiesAndNumPopulation = new Dictionary<string, double>();
        }
        public double NumPopulation { get; set; }

    }
}
