using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ShorterWordsSorted
{
    class ShorterWordsSorted
    {
        static void Main(string[] args)
        {
            string[] wordsArray = Console.ReadLine().ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .OrderBy(x => x)
                .ToArray();

            wordsArray = wordsArray.Where(x=>x.Length<5).ToArray();
            Console.WriteLine(string.Join(", ", wordsArray));
        }
    }
}
