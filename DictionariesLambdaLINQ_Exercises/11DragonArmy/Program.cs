using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> myDragonDict = new Dictionary<string, List<Dragon>>();
            int numCommands = int.Parse(Console.ReadLine());
            while (numCommands > 0)
            {
                string[] commandInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                Dragon newDragon = CreateNewDragon(commandInfo);
                if (myDragonDict.ContainsKey(newDragon.Type))//first check if myDragonDict contains key like the type of the newDragon
                {// if it does, then check if the myDragonDict Value(which is a list) contains dragon with that name like the name of the newDragon
                    if (myDragonDict[newDragon.Type].Any(d => d.Name.Equals(newDragon.Name)))
                    {// if it does, then overwrite the other properties
                        myDragonDict[newDragon.Type].First(d => d.Name.Equals(newDragon.Name)).Damage = newDragon.Damage;
                        myDragonDict[newDragon.Type].First(d => d.Name.Equals(newDragon.Name)).Health = newDragon.Health;
                        myDragonDict[newDragon.Type].First(d => d.Name.Equals(newDragon.Name)).Armor = newDragon.Armor;
                    }
                    else
                    {// if such dragon doesn't exist in the list of dragons (which is the value in the myDragonDict, then add it to the list
                        myDragonDict[newDragon.Type].Add(newDragon);
                    }
                }
                else
                {// if myDragonDict doensn't contain key like the type of the newDragon
                    myDragonDict.Add(newDragon.Type, new List<Dragon>()); // create new KeyValuePair and initialize the list of dragons;
                    myDragonDict[newDragon.Type].Add(newDragon); //add the newDragon to the list of dragons with that type
                }

                numCommands--;
            }

            foreach (var t in myDragonDict)
            {
                double avrgDamageForType = t.Value.Select(d => d.Damage).Average();
                double avrgHealthForType = t.Value.Select(d => d.Health).Average();
                double avrgArmorForType = t.Value.Select(d => d.Armor).Average();
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", t.Key, avrgDamageForType, avrgHealthForType, avrgArmorForType);
                foreach(Dragon d in t.Value.OrderBy(d=>d.Name))
                {
                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", d.Name, d.Damage, d.Health, d.Armor);
                }
            }
        }

        private static Dragon CreateNewDragon(string[] arrayInfo)
        {
            string dragonType = arrayInfo[0];
            string dragonName = arrayInfo[1];

            double dragonDamage = 45; // by default
            if (double.TryParse(arrayInfo[2], out dragonDamage))
            {// if TryParse returns true, then parse the info from the array.
                dragonDamage = double.Parse(arrayInfo[2]);
            }
            else
            {
                dragonDamage = 45;
            }
            double dragonHealth = 250; // by default
            if (double.TryParse(arrayInfo[3], out dragonHealth))
            {// if TryParse returns true, then parse the info from the array.
                dragonHealth = double.Parse(arrayInfo[3]);
            }
            else
            {
                dragonHealth = 250;
            }
            double dragonArmor = 10; // by default
            if (double.TryParse(arrayInfo[4], out dragonArmor))
            {// if TryParse returns true, then parse the info from the array.
                dragonArmor = double.Parse(arrayInfo[4]);
            }
            else
            {
                dragonArmor = 10;
            }

            Dragon newDragon = new Dragon()
            {
                Type = dragonType,
                Name = dragonName,
                Damage = dragonDamage,
                Health = dragonHealth,
                Armor = dragonArmor
            };
            return newDragon;

        }
    }
    public class Dragon
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public double Damage { get; set; }
        public double Health { get; set; }
        public double Armor { get; set; }
    }
}
