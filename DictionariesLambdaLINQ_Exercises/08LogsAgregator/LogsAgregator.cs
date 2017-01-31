using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08LogsAgregator
{
    class LogsAgregator
    {
        static void Main(string[] args)
        {
            int numInputs = int.Parse(Console.ReadLine());
            List<User> ListOfUsers = new List<User>(); 
            for(int i =0; i<numInputs; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(' ').ToArray();
                User newUser = new User() { Name = inputInfo[1] };
                if(ListOfUsers.Any(u=>u.Name == inputInfo[1]))  // check if ListOfUsers contains item with name like that of the newUser
                {//if it contains, then need to check if IPLogs of this item/object/ contains IP like that in the inputInfo
                    if(!ListOfUsers.First(u=>u.Name==inputInfo[1]).IPLogs.Contains(inputInfo[0]))
                    {//if it doesn't contain - add it to the list
                        ListOfUsers.First(u => u.Name == inputInfo[1]).IPLogs.Add(inputInfo[0]);
                    }
                    // then we need to add the duration from the inputInfo to the duration of the object;
                    ListOfUsers.First(u => u.Name == inputInfo[1]).Duration += int.Parse(inputInfo[2]);
                }
                else
                {// if the list doesn't contain item with name like the one in the inputInfo
                    // we first add the info from the inputInfo to the newUser;
                    newUser.Duration = int.Parse(inputInfo[2]);
                    newUser.IPLogs.Add(inputInfo[0]);
                    // then we add the newUser to the ListOfUsers
                    ListOfUsers.Add(newUser);
                }

            }

            ListOfUsers = ListOfUsers.OrderBy(u => u.Name).ToList();
            for(int i =0; i<ListOfUsers.Count; i++)
            {
                ListOfUsers[i].IPLogs = ListOfUsers[i].IPLogs.OrderBy(s => s).ToList();
                Console.WriteLine("{0}: {1} [{2}]", ListOfUsers[i].Name, ListOfUsers[i].Duration, string.Join(", ", ListOfUsers[i].IPLogs));
            }

        }
    }
    public class User
    {
        public string Name { get; set; }
        public List<string> IPLogs { get; set; }
        public User()
        {
            IPLogs = new List<string>();
        }
        public int Duration { get; set; }
    }
}
