using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03PhoneProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();
            while (true)
            {
                inputs.Add(Console.ReadLine().ToLower());
                if(inputs[inputs.Count-1] == "end")
                {
                    break;
                }
            }
            //string[] inputsArr = inputs.ToArray();

            int prcntBatt = default(int);
            int prcntApp = default(int);
            int cntApps = inputs.Count - 2;
            if(inputs[0].Length == 2)
            {
                prcntBatt = int.Parse(inputs[0].Substring(0, 1));
            }
            else if(inputs[0].Length == 3)
            {
                prcntBatt = int.Parse(inputs[0].Substring(0, 2));
            }
            else if (inputs[0].Length == 4)
            {
                prcntBatt = int.Parse(inputs[0].Substring(0, 3));
            }

            for (int i = 1; i<=inputs.Count-2; i++)
            {
                string[] arr = inputs[i].Split('_').ToArray();
                prcntApp = int.Parse(arr[arr.Length-1].Substring(0, 2));
                if(prcntBatt-prcntApp>15)
                {
                    prcntBatt -= prcntApp;
                    cntApps--;
                    if(i== inputs.Count - 2)
                    {
                        Console.WriteLine("Successful complete -> {0}%", prcntBatt);
                    }
                }
                else if(prcntBatt-prcntApp<=15 && prcntBatt-prcntApp>0)
                {
                    //prcntBatt -= prcntApp;
                    Console.WriteLine("Connect charger -> {0}%", prcntBatt);
                    //cntApps--;
                    Console.WriteLine("Programs left -> {0}", cntApps);
                    break;
                }
                else if(prcntBatt - prcntApp <= 0)
                {
                    Console.WriteLine("Phone Off");
                    break;
                }
            }

        }
    }
}
