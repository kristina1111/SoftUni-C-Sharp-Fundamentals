using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> legendaryKeyMaterial = new Dictionary<string, string>()
            {
                {"shards","Shadowmourne"},
                {"fragments", "Valanyr"},
                {"motes", "Dragonwrath"}
            };

            Dictionary<string, int> keyMaterials = new Dictionary<string, int>()
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0}
            };

            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            string keyMaterialGreatest = "";
            string[] inputInfo = Console.ReadLine().ToLower().Split(' ').ToArray();
            while(true)
            {
                for(int i =1; i<inputInfo.Length; i+=2)
                {
                    if(keyMaterials.ContainsKey(inputInfo[i]))
                    {
                        keyMaterials[inputInfo[i]] += int.Parse(inputInfo[i - 1]);
                        if(keyMaterials[inputInfo[i]]>=250)
                        {
                            keyMaterialGreatest = inputInfo[i];
                            break;
                        }
                        continue;
                    }
                    else if(junkMaterials.ContainsKey(inputInfo[i]))
                    {
                        junkMaterials[inputInfo[i]] += int.Parse(inputInfo[i - 1]);
                        continue;
                    }
                    else
                    {
                        junkMaterials.Add(inputInfo[i], int.Parse(inputInfo[i - 1]));
                    }
                }
                
                if(keyMaterials["shards"] >= 250 || keyMaterials["fragments"] >= 250 || keyMaterials["motes"] >= 250)
                {
                    break;
                }

                inputInfo = Console.ReadLine().ToLower().Split(' ').ToArray();
            }

            Console.WriteLine("{0} obtained!", legendaryKeyMaterial[keyMaterialGreatest]);
            keyMaterials[keyMaterialGreatest] -= 250;
            keyMaterials = keyMaterials.OrderByDescending(v => v.Value).ThenBy(k => k.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach(var p in keyMaterials)
            {
                Console.WriteLine("{0}: {1}", p.Key, p.Value);
            }

            junkMaterials = junkMaterials.OrderBy(k => k.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var p in junkMaterials)
            {
                Console.WriteLine("{0}: {1}", p.Key, p.Value);
            }
        }
    }
}
