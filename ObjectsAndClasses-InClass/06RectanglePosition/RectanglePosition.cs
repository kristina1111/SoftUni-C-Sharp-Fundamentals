using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RectanglePosition
{
    class RectanglePosition
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = GetRectangle(Console.ReadLine().Split(' ').ToArray());
            Rectangle rect2 = GetRectangle(Console.ReadLine().Split(' ').ToArray());
            if(rect1.isInside(rect2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        static Rectangle GetRectangle(string[] inputArray)
        {
            Rectangle rect = new Rectangle()
            {
                X = double.Parse(inputArray[0]),
                Y = double.Parse(inputArray[1]),
                Width = double.Parse(inputArray[2]),
                Height = double.Parse(inputArray[3])
            };
            
            return rect;
        }
    }
    class Rectangle
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        
        public bool isInside(Rectangle r)
        {
            bool isInside = r.X <= X && r.X + r.Width >= X + Width && r.Y <= Y && r.Y + r.Height >= Y + Height;
            return isInside;
        }
    }
}
