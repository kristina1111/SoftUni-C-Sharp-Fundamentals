using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08Firefighters
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            string kids = null;
            string adults = null;
            string seniors = null;

            int kidsSaved = default(int);
            int adultsSaved = default(int);
            int seniorsSaved = default(int);

            while (input != "rain")
            {
                int cntKids = default(int);
                int cntAdults = default(int);
                int cntSeniors = default(int);

                foreach (char i in input)
                {
                    if (i == 'K')
                    {
                        kids += i;
                    }
                    else if (i == 'A')
                    {
                        adults += i;
                    }
                    else if (i == 'S')
                    {
                        seniors += i;
                    }
                }
                input = kids + adults + seniors;
                for (int k = 0; k<(num<input.Length ? num : input.Length); k++)
                {
                    if (input[k] == 'K')
                    {
                        kidsSaved++;
                    }
                    else if(input[k] == 'A')
                    {
                        adultsSaved++;
                    }
                    else if(input[k] == 'S')
                    {
                        seniorsSaved++;
                    }
                }
                input = Console.ReadLine();
                kids = null;
                adults = null;
                seniors = null;
            }
            Console.WriteLine("Kids: {0}\nAdults: {1}\nSeniors: {2}", kidsSaved, adultsSaved, seniorsSaved);
        }
    }
}
