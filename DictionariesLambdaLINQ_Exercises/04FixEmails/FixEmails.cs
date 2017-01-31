using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            string[] inputArray = new string[2];
            Dictionary<string, string> emailBook = new Dictionary<string, string>();
            inputArray[0] = Console.ReadLine();
            while (!inputArray[0].Equals("stop"))
            {
                inputArray[1] = Console.ReadLine();
                if (inputArray[1].Substring(inputArray[1].Length - 2, 2) == "uk" ||
                    inputArray[1].Substring(inputArray[1].Length - 2, 2) == "us")
                {
                    inputArray[0] = Console.ReadLine();
                    continue;
                }

                if (!emailBook.ContainsKey(inputArray[0]))
                {
                    emailBook.Add(inputArray[0], inputArray[1]);
                }
                else
                {
                    emailBook[inputArray[0]] = inputArray[1];
                }

                inputArray[0] = Console.ReadLine();
            }

            foreach(KeyValuePair<string, string> p in emailBook)
            {
                Console.WriteLine("{0} -> {1}", p.Key, p.Value);
            }
        }
    }
}
