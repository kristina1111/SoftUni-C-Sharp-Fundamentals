using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E03NetherRealm
{
    class NetherRealm
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<Deamon> listOfDeamons = new List<Deamon>();
            string patternForHealth = @"([^0-9\+\-\.\/\*])";
            string patternForDamage = @"(\-?[0-9]+(\.[\d]+)*)";
            string patternForMultAndDiv = @"([\*\/])";
            Regex rgxForHealth = new Regex(patternForHealth);
            Regex rgxForDamage = new Regex(patternForDamage);
            Regex rgxForMultAndDiv = new Regex(patternForMultAndDiv);

            for (int i = 0; i < input.Length; i++)
            {
                Deamon newDeamon = new Deamon() { Name = input[i], Health = 0, Damage = 0 };
                bool isMatchForHealth = rgxForHealth.IsMatch(newDeamon.Name);
                if(isMatchForHealth)
                {
                    MatchCollection matches = rgxForHealth.Matches(newDeamon.Name);
                    StringBuilder sb = new StringBuilder();
                    foreach(Match m in matches)
                    {
                        sb.Append(m.ToString());
                    }
                    string charsForHealth = sb.ToString();
                    foreach(char c in charsForHealth)
                    {
                        newDeamon.Health += (double)c;
                    }
                }

                bool isMatchForDamage = rgxForDamage.IsMatch(newDeamon.Name);
                if(isMatchForDamage)
                {
                    MatchCollection matches = rgxForDamage.Matches(newDeamon.Name);
                    foreach (Match m in matches)
                    {
                        int cntDots = m.ToString().Count(d => d == '.');

                        if (cntDots == 0 || cntDots==1 )
                        {
                            newDeamon.Damage += double.Parse(m.ToString());
                        }
                    }

                    bool ismatchForMultAndDiv = rgxForMultAndDiv.IsMatch(newDeamon.Name);
                    if(ismatchForMultAndDiv)
                    {
                        MatchCollection matchesForMultAndDiv = rgxForMultAndDiv.Matches(newDeamon.Name);
                        foreach(Match mm in matchesForMultAndDiv)
                        {
                            if (mm.ToString()=="*")
                            {
                                newDeamon.Damage *= (double)2;
                            }
                            else if(mm.ToString() == "/")
                            {
                                newDeamon.Damage /= (double)2;
                            }
                        }
                    }

                }

                listOfDeamons.Add(newDeamon);
            }

            foreach(Deamon d in listOfDeamons.OrderBy(d=>d.Name))
            {
                Console.WriteLine("{0} - {1} health, {2:f2} damage", d.Name, d.Health, d.Damage);
            }
        }
    }
    class Deamon
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double Damage { get; set; }
    }
}
