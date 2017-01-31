using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _0802MentorGroup
{
    class MentorGroup
    {
        static void Main(string[] args)
        {// Judge - 100/100
            string command = Console.ReadLine();
            SortedDictionary<string, Student> myMentorGroup = new SortedDictionary<string, Student>();
            while (!command.Equals("end of dates"))
            {
                string[] inputInfo = command.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int inputLength = inputInfo.Length;
                Student newStudent = new Student() { Name = inputInfo[0] };
                if (myMentorGroup.ContainsKey(inputInfo[0]))  // check if myMentorGroup dictionary already contains such student with that name
                {// if it contains, check if its list DatesAttended contains such date
                    for (int i = 1; i < inputLength; i++)
                    {
                        //if (!myMentorGroup[inputInfo[0]].DatesAttended.Contains(DateTime.ParseExact(inputInfo[i], "dd/MM/yyyy", null)))
                        //{// if it doesn't contain such date - add it to the list
                        myMentorGroup[inputInfo[0]].DatesAttended.Add(DateTime.ParseExact(inputInfo[i], "dd/MM/yyyy", null));
                        //}
                    }
                }
                else
                {// if myMentorGroup dictionary doesn't contain such student
                 //if (inputLength > 1)
                 //{
                    for (int i = 1; i < inputLength; i++) // first add the dates to the newStudent list DatesAttended
                    {
                        newStudent.DatesAttended.Add(DateTime.ParseExact(inputInfo[i], "dd/MM/yyyy", null));
                    }
                    myMentorGroup.Add(newStudent.Name, newStudent); // then add newStudent to myMentorGroup
                    //}

                }
                command = Console.ReadLine();
            }

            while (!command.Equals("end of comments"))
            {
                string[] inputInfo = command.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int inputLength = inputInfo.Length;
                Student newStudent = new Student() { Name = inputInfo[0] };
                if (myMentorGroup.ContainsKey(inputInfo[0]))  // check if myMentorGroup dictionary already contains such student with that name
                {// if it contains, check if its list CommentsReceived contains such comment
                    if (inputLength > 1)
                    {
                        //if (!myMentorGroup[inputInfo[0]].CommentsReceived.Equals(inputInfo[1]))
                        //{// if it doesn't contain such comment - add that comment to the list CommentsReceived
                        myMentorGroup[inputInfo[0]].CommentsReceived.Add(inputInfo[1]);
                        //}
                    }
                }
                command = Console.ReadLine();
            }

            foreach (var s in myMentorGroup)
            {
                Console.WriteLine(s.Key);

                s.Value.DatesAttended.Sort((a, b) => a.CompareTo(b));
                Console.WriteLine("Comments:");
                foreach (var c in s.Value.CommentsReceived)
                {
                    Console.WriteLine("- {0}", c);
                }
                Console.WriteLine("Dates attended:");
                foreach (var d in s.Value.DatesAttended)
                {
                    Console.WriteLine("-- {0:dd/MM/yyyy}", d);
                }
            }
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public List<DateTime> DatesAttended { get; set; }
        public List<string> CommentsReceived { get; set; }
        public Student()
        {
            DatesAttended = new List<DateTime>();
            CommentsReceived = new List<string>();
        }
    }
}
