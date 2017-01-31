using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05HandsOfCads
{
    class HandsOfCads
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> participantsHands = new Dictionary<string, string>();
            Dictionary<string, int> participantsResults = new Dictionary<string, int>();
            string command = Console.ReadLine();
            while(!command.Equals("JOKER"))
            {
                string[] infoToSplit = command.Split(':').Select(x=>x.Trim()).ToArray();
                if (!participantsHands.ContainsKey(infoToSplit[0]))
                {
                    participantsHands.Add(infoToSplit[0], infoToSplit[1]);
                }
                else
                {
                    participantsHands[infoToSplit[0]] += ", " + infoToSplit[1];
                }
                
                command = Console.ReadLine();
            }

            Dictionary<string, int> cardPowerInfo = new Dictionary<string, int>()
            {
                {"2",2 },
                {"3",3 },
                {"4",4 },
                {"5",5 },
                {"6",6 },
                {"7",7 },
                {"8",8 },
                {"9",9 },
                {"10",10 },
                {"J",11 },
                {"Q",12 },
                {"K",13 },
                {"A",14 },
                {"S",4 },
                {"H",3 },
                {"D",2 },
                {"C",1 },
            };

            foreach(var p in participantsHands)
            {
                participantsResults.Add(p.Key, 0);
                int sumParticipant = 0;
                string[] handToSplit = p.Value.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                handToSplit = handToSplit.Distinct().ToArray();
                string cardType = "";
                string cardPower = "";
                for(int i = 0; i<handToSplit.Length; i++)
                {
                    cardType = handToSplit[i][handToSplit[i].Length - 1].ToString();
                    cardPower = handToSplit[i].Remove(handToSplit[i].Length - 1);
                    sumParticipant += cardPowerInfo[cardType] * cardPowerInfo[cardPower];
                }
                participantsResults[p.Key] = sumParticipant;

                Console.WriteLine("{0}: {1}", p.Key, sumParticipant);
            }
        }
    }
}