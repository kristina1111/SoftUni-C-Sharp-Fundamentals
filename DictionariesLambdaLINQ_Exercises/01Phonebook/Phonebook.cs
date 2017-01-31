using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            string[] commandArray = Console.ReadLine().Split(' ').ToArray();
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            while(!commandArray[0].Contains("END"))
            {
                if(commandArray[0].Contains("A"))
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
                else if(commandArray[0].Contains("S"))
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

                commandArray = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
