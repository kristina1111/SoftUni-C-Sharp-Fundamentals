using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03AMinerTaks
{
    class AMinerTaks
    {
        static void Main(string[] args)
        {
            string[] inputArray = new string[2];
            Dictionary<string, int> resources = new Dictionary<string, int>();
            inputArray[0] = Console.ReadLine();
            while(!inputArray[0].Equals("stop"))
            {
                inputArray[1] = Console.ReadLine();
                if(!resources.ContainsKey(inputArray[0]))
                {
                    resources.Add(inputArray[0], 0);
                }

                resources[inputArray[0]] += int.Parse(inputArray[1]);

                inputArray[0] = Console.ReadLine();
            }
            foreach(KeyValuePair<string, int> p in resources)
            {
                Console.WriteLine("{0} -> {1}", p.Key, p.Value);
            }
            

        }
    }
}
