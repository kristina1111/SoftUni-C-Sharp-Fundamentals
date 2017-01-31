using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            //double lenght, width, height = 0;
            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (lenght * height * width) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
