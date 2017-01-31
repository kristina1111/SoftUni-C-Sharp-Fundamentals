using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02AdvertisementMessage
{
    class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] author = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberMessages = int.Parse(Console.ReadLine());
            Random rndm = new Random();
            int rndmNum = rndm.Next();
            while(numberMessages>0)
            {
                Console.WriteLine("{0} {1} {2} - {3}", phrases[rndmNum % phrases.Length], events[rndmNum%events.Length], author[rndmNum%author.Length], cities[rndmNum%cities.Length]);
                rndmNum = rndm.Next();
                numberMessages--;
            }
        }
    }
}
