using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06UserLogs
{
    class UserLogs
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<User> UserInfoToPrint = new List<User>();
            while(!command.Equals("end"))
            {
                string[] inputInfo = command.Split(new[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries).ToArray();  // split the command message into array
                User newUser = new User() { Name = inputInfo[5] } ;   // create new object User
                if(!UserInfoToPrint.Any(x=>x.Name.Equals(newUser.Name)))   // if the new object with name given is not in the list:
                {
                    newUser.IPandNumberCounts.Add(inputInfo[1], 1);    // add to that user the info about the IP and count of the messages sent from that IP
                    UserInfoToPrint.Add(newUser);  // then add User to List if it is not in it.
                }
                else  // if User is in the list:
                {  // check if its IPandNumberCounts Dictionary contains the IP in the command
                    if (!UserInfoToPrint.First(x => x.Name.Equals(inputInfo[5])).IPandNumberCounts.ContainsKey(inputInfo[1]))
                    { // if it doesn't contain it - then add it in the dictionary
                        UserInfoToPrint.First(x => x.Name.Equals(inputInfo[5])).IPandNumberCounts.Add(inputInfo[1], 1);
                    }
                    else  // if it contains it - add 1 to the dictionary value (count of the IP)
                    {
                        UserInfoToPrint.First(x => x.Name.Equals(inputInfo[5])).IPandNumberCounts[inputInfo[1]] += 1;
                    }
                }

                command = Console.ReadLine();
            }
            UserInfoToPrint = UserInfoToPrint.OrderBy(x => x.Name).ToList();  // sort items in the list alphabetically by name.
            for(int i = 0; i<UserInfoToPrint.Count; i++)  //For each 
            {
                Console.WriteLine("{0}: ", UserInfoToPrint[i].Name);  // print the name of each item in the list
                foreach(var p in UserInfoToPrint[i].IPandNumberCounts)
                { // for each item print every key and value in the dictionary of IP and message counter
                    Console.Write("{0} => {1}", p.Key, p.Value);
                    if(p.Key.Equals(UserInfoToPrint[i].IPandNumberCounts.Last().Key)) 
                    {  // if the last key and value are printed - print "."
                        Console.WriteLine(".");
                    }
                    else
                    { // if it is not the last key and value - print ","
                        Console.Write(", ");
                    }
                }
            }

        }
    }
    public class User
    {
        public string Name { get; set; }
        public  Dictionary<string, int> IPandNumberCounts { get; set; }
        public User()
        {
            IPandNumberCounts = new Dictionary<string, int>();
        }
    }
}
