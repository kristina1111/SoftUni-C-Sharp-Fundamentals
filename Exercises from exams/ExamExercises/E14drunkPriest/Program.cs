using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E14drunkPriest
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                sbyte nRooms = sbyte.Parse(Console.ReadLine());
                string lDState = Console.ReadLine().ToLower();
                char[] roomsArr = new char[nRooms];

                for (int i = 0; i < roomsArr.Length; i++)
                {
                    roomsArr[i] = lDState[i % lDState.Length];
                }

                //foreach(char i in roomsArr)
                //{
                //    Console.Write(i);
                //}

                int currPos = (nRooms - 1) / 2;
                int prevPos = currPos;
                string input = Console.ReadLine().ToLower();

                while (input != "end")
                {
                    string direction = input.Split(' ').ToArray()[0];
                    int steps = int.Parse(input.Split(' ').ToArray()[1]);

                    if (direction == "left") //start+steps>roomsArr.Length || 
                    {
                        prevPos = currPos;
                        currPos = (currPos - steps - 1 < 0 ? 0 : currPos - steps - 1);
                    }
                    else
                    {
                        prevPos = currPos;
                        currPos = (currPos + steps + 1 >= roomsArr.Length - 1 ? roomsArr.Length - 1 : currPos + steps + 1);
                    }

                    if(prevPos !=currPos)
                    {
                        roomsArr[currPos] = (roomsArr[currPos] == 'l' ? 'd' : 'l');
                    }
                    

                    input = Console.ReadLine().ToLower();
                }
                int cntD = 0;
                foreach (char i in roomsArr)
                {
                    if (i == 'd')
                    {
                        cntD += 1;
                    }
                }
                Console.WriteLine(68 * cntD);
            }
            

        }
    }
}
