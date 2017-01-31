using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E04RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Event> listOfEvents = new List<Event>();
            string pattern = @"(?<=^)(([^#@]+)[ \t]+#([^#@]*)(([ \t]+@[^#@]*)*)(?=$))"; //@"(?<=^)(([\d]+) #([^#@]+)(( @[^#@]+)*)(?=$))"
            Regex rgxToCheckValidity = new Regex(pattern);
            //string ptrnForID = @"(?<=^)([\d]+)(?= #)";
            //Regex rgxForID = new Regex(ptrnForID);
            //string ptrnForName = @"(?<=#)([^#@ ]+)(?= @)";
            //Regex rgxForName = new Regex(ptrnForName);

            string inputInfo = Console.ReadLine();
            while (!inputInfo.ToLower().Equals("time for code"))
            {
                bool ismatch = rgxToCheckValidity.IsMatch(inputInfo);
                if (!ismatch)
                {
                    inputInfo = Console.ReadLine();
                    continue;
                }
                MatchCollection matches = rgxToCheckValidity.Matches(inputInfo);
                string[] arrayInfo = new string[] { "", "", "" };
                int cnt = 0;

                foreach (Match m in matches)
                {
                    arrayInfo[0] = m.Groups[2].ToString();
                    arrayInfo[1] = m.Groups[3].ToString();
                    if(m.ToString().Any(c=>c=='@'))
                    {
                        int index = m.ToString().IndexOf('@');
                        //int nextInd = m.ToString().IndexOf('@', index + 1);
                        arrayInfo[2] = m.ToString().Substring(index);
                    }
                }

                Event newEvent = new Event()
                {
                    ID = arrayInfo[0],
                    Name = arrayInfo[1]
                };
                string[] participantsInfo = arrayInfo[2].Split(new[] {'@'}, StringSplitOptions.RemoveEmptyEntries).ToArray(); //
                for (int i = 0; i < participantsInfo.Length; i++)
                {
                    //if(participantsInfo[i]!="")
                    //{
                        newEvent.Participants.Add(participantsInfo[i].TrimStart('@').TrimEnd(' '));
                    //}
                    
                }

                if (listOfEvents.Any(e => e.ID.Equals(newEvent.ID)))
                {
                    if (listOfEvents.First(e => e.ID.Equals(newEvent.ID)).Name.Equals(newEvent.Name))
                    {
                        for (int i = 0; i < newEvent.Participants.Count; i++)
                        {
                            if(!listOfEvents.First(e => e.ID.Equals(newEvent.ID)).Participants.Any(x=>x.Equals(newEvent.Participants[i])))
                            {
                                listOfEvents.First(e => e.ID.Equals(newEvent.ID)).Participants.Add(newEvent.Participants[i]);
                            }
                        }
                    }
                    else
                    {
                        inputInfo = Console.ReadLine();
                        continue;
                    }
                }
                else
                {
                    listOfEvents.Add(newEvent);
                }

                inputInfo = Console.ReadLine();
            }

            listOfEvents = listOfEvents.OrderByDescending(e => e.Participants.Count).ThenBy(e => e.Name).ToList();

            foreach (Event e in listOfEvents)
            {
                Console.WriteLine("{0} - {1}", e.Name.Trim(' '), e.Participants.Count);
                foreach (string p in e.Participants.OrderBy(n => n))
                {
                    Console.WriteLine("@{0}", p);
                }
            }


        }
    }
    class Event
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public List<string> Participants { get; set; }
        public Event()
        {
            Participants = new List<string>();
        }

    }

}
