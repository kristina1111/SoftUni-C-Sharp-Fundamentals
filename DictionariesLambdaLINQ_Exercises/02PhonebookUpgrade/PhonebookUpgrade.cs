using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            string[] commandArray = Console.ReadLine().Split(' ').ToArray();
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
            while (!commandArray[0].Equals("END"))
            {
                if (commandArray[0].Equals("A"))
                {
                    if (!phoneBook.ContainsKey(commandArray[1]))
                    {
                        phoneBook.Add(commandArray[1], commandArray[2]);
                    }
                    else
                    {
                        phoneBook[commandArray[1]] = commandArray[2];
                    }
                }
                else if (commandArray[0].Equals("S"))
                {
                    if (phoneBook.ContainsKey(commandArray[1]))
                    {
                        Console.WriteLine("{0} -> {1}", commandArray[1], phoneBook[commandArray[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", commandArray[1]);
                    }
                }
                else if(commandArray[0].Equals("ListAll"))
                {
                    foreach(KeyValuePair<string, string> p in phoneBook)
                    {
                        Console.WriteLine("{0} -> {1}", p.Key, p.Value);
                    }
                }

                commandArray = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
