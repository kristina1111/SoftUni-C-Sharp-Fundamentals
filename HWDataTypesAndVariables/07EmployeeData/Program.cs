using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string frstName = Console.ReadLine();
            Console.WriteLine("First name: {0}", frstName);
            string lstName = Console.ReadLine();
            Console.WriteLine("Last name: {0}", lstName);
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Age: {0}", age);
            char gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Gender: {0}", gender);
            long ID = long.Parse(Console.ReadLine());
            Console.WriteLine("Personal ID: {0}", ID);
            int empNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Unique Employee number: {0}", empNum);

        }
    }
}
