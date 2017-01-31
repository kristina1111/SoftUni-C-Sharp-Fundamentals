using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04AverageGrades
{
    class AverageGrades
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            Student[] Students = new Student[numStudents];
            for(int i = 0; i<numStudents; i++)
            {
                string[] inputInfo = Console.ReadLine().Split(new[] { ' ' }, 2).Select(s=>s.Trim()).ToArray();
                Students[i] = ReturnStudent(inputInfo);
            }
            Students = Students.OrderBy(p => p.Name).ThenByDescending(p => p.AverageGrade).ToArray();
            foreach(Student x in Students)
            {
                if(x.AverageGrade>=5)
                {
                    Console.WriteLine("{0} -> {1:f2}", x.Name, x.AverageGrade);
                }
            }

        }
        static Student ReturnStudent(string[] infoArray)
        {
            Student student = new Student()
            {
                Name = infoArray[0],
                ListOfGrades = infoArray[1].Split(' ').Select(double.Parse).ToArray(),
            };
            return student;
        }

    }
    class Student
    {
        public string Name { get; set; }
        public double[] ListOfGrades { get; set; }
        public double AverageGrade
        {
            get
            {
                return ListOfGrades.Average();
            }
        }
    }
}
