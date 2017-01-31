using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int numTeamsCreated = int.Parse(Console.ReadLine());
            int numZeroTeams = numTeamsCreated;
            List<Team> ListOfTeams = new List<Team>();
            string command = Console.ReadLine();
            while (numTeamsCreated > 0)
            {
                string[] inputInfo = command.Split('-').ToArray();
                Team newTeam = new Team() { CreatorName = inputInfo[0], Name = inputInfo[1] };

                if (ListOfTeams.Any(t => t.Name == newTeam.Name))  // check if team with that name exists in the ListOfTeams
                {// if it exists, then a message is thrown:
                    Console.WriteLine("Team {0} was already created!", newTeam.Name);
                    command = Console.ReadLine();  // read new input from the console
                    numTeamsCreated--;
                    continue;  // return from the beginning;
                }
                else if (ListOfTeams.Any(t => t.CreatorName == newTeam.CreatorName))
                {// check if the creator of the new team has already created a team. If Yes, then a message is thrown:
                    Console.WriteLine("{0} cannot create another team!", newTeam.CreatorName);
                    command = Console.ReadLine();  // read new input from the console
                    numTeamsCreated--;
                    continue;  // return from the beginning;
                }
                else
                {// if none of the above checks is true, 
                    newTeam.ListOfmembers.Add(inputInfo[0]);  // add the name of the creator of the team to the ListOfMembers of the current newTeam;
                    ListOfTeams.Add(newTeam); //then the newTeam is added to the ListOfTeams
                    Console.WriteLine("Team {0} has been created by {1}!", newTeam.Name, newTeam.CreatorName); // print that message about the creation of the team
                }

                command = Console.ReadLine();  // read new input from the console
                numTeamsCreated--;
            }

            while (!command.Equals("end of assignment"))
            {
                string[] inputInfo = command.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (ListOfTeams.Any(t => t.Name == inputInfo[1])) // check if there is a team which name is the same like that from the command
                { // that will show if such team exists;  If it exists, then check:
                    if (ListOfTeams.Any(t => t.ListOfmembers.Contains(inputInfo[0]))) // if the applicant is in any of the teams
                    {//ListOfTeams.First(t=>t.Name == inputInfo[1]).ListOfmembers.Contains(inputInfo[0]) -> that check is not necessary
                        Console.WriteLine("Member {0} cannot join team {1}!", inputInfo[0], inputInfo[1]);
                    }
                    else // if the applicant is not in any of the teams
                    {// add it to the team with that name
                        ListOfTeams.First(t => t.Name == inputInfo[1]).ListOfmembers.Add(inputInfo[0]);
                    }
                }
                else
                {
                    Console.WriteLine("Team {0} does not exist!", inputInfo[1]);
                }

                command = Console.ReadLine();  // read new input from the console
            }
            ListOfTeams = ListOfTeams.OrderByDescending(t => t.ListOfmembers.Count).ThenBy(t => t.Name).ToList();
            bool printIsDisband = true;
            foreach (var t in ListOfTeams)  // for every team in ListOfTeams
            {
                t.ListOfmembers = t.ListOfmembers.OrderBy(m => m).ToList(); // first sort the listOfMembers of every team alphabetically
                if (t.ListOfmembers.Count > 1) // then for every team that has more than one member /that one member would be the creator/
                {// print those properties
                    Console.WriteLine(t.Name);
                    Console.WriteLine("- {0}", t.CreatorName);
                    foreach (var m in t.ListOfmembers) // for every member in the ListOfMembers of every team...
                    {
                        if (!m.Equals(t.CreatorName)) // ...exept for the creator...
                        {
                            Console.WriteLine("-- {0}", m); // ...print the name of the member
                        }
                    }
                    if (t == ListOfTeams[ListOfTeams.Count - 1])
                    {
                        Console.WriteLine("Teams to disband:"); // this message is printed, 
                    }
                }
                else // the teams are ordered by number of members so...
                {
                    if (printIsDisband == true) // the first time that "else" is triggered
                    {
                        Console.WriteLine("Teams to disband:"); // this message is printed, 
                        printIsDisband = false; //and it will not be printed any more
                    }
                    Console.WriteLine(t.Name);  // only the names of the teams with no other members exept their creator will be printed 
                }
            }
            if (numZeroTeams == 0)
            {
                Console.WriteLine("Teams to disband:");
            }
        }
    }
    public class Team
    {
        public string CreatorName { get; set; }
        public string Name { get; set; }
        public List<string> ListOfmembers { get; set; }
        public Team()
        {
            ListOfmembers = new List<string>();
        }
    }
}
