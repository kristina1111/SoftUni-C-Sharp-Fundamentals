using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02LadyBugs
{
    class LadyBugs
    {
        static void Main(string[] args)
        {
            long arrayLength = long.Parse(Console.ReadLine());
            bool[] bugArray = new bool[arrayLength]; // all false!
            long[] arrayBugIndexes = Console.ReadLine().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            for (long i = 0; i < arrayBugIndexes.Length; i++)
            {
                if (!(arrayBugIndexes[i] >= 0 && arrayBugIndexes[i] < bugArray.Length))
                {//if the given index is outside the range of array
                    continue;
                }
                else if (bugArray[arrayBugIndexes[i]] == true)
                {//if there is a ladybug already
                    continue;
                }
                else
                {// the value with that index becomes true - there is a ladybug
                    bugArray[arrayBugIndexes[i]] = true;
                }
            }

            string command = Console.ReadLine().ToLower();
            while (!command.Equals("end"))
            {
                string[] commandInfo = command.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                long indexBug = long.Parse(commandInfo[0]);
                long flightLength = long.Parse(commandInfo[2]);
                string direction = commandInfo[1];

                if (flightLength <= 0)
                {
                    //command = Console.ReadLine().ToLower();
                    //continue;
                    direction = direction == "right" ? "left" : "right";
                    flightLength = Math.Abs(flightLength);
                }

                if (!(indexBug >= 0 && indexBug < bugArray.Length))
                {//if the given index is not in the range of the ladybugArray 
                    command = Console.ReadLine().ToLower();
                    continue;
                }
                else //if the given index is in the range, check if if there are no ladybig on that index
                {// if there are a ladybug on that index, check 
                    if (!bugArray[indexBug] == true)
                    {
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    else
                    {// if there are a ladybug on that index, check if the flight it will fly stays in the range of the bugArray
                        bugArray[indexBug] = false; // the ladybug starts flying
                        if (direction.Equals("right"))
                        {
                            
                            if (indexBug + flightLength < bugArray.Length)
                            {
                                
                                bool hasLanded = true;
                                long toAdd = flightLength;
                                while (hasLanded)
                                {
                                    if(indexBug + flightLength < bugArray.Length) //
                                    {// if while flying the ladybug stays in the range of the ugArray
                                        if (bugArray[indexBug + flightLength] == false) // check if there are another ladyBug on the new index
                                        {// if there is not, then the ladybug lands there and the while loop ends
                                            bugArray[indexBug + flightLength] = true;
                                            hasLanded = false;
                                        }
                                        else
                                        {// else the ladybug continues flying with the same length
                                            flightLength += toAdd;
                                        }  
                                    }
                                    else
                                    {
                                        hasLanded = false;
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                command = Console.ReadLine().ToLower();
                                continue;
                            }
                        }
                        else if (direction.Equals("left"))
                        {
                            if(indexBug-flightLength>=0)
                            {
                                bool hasLanded = true;
                                long toAdd = flightLength;
                                while (hasLanded)
                                {
                                    if (indexBug - flightLength >= 0) //
                                    {// if while flying the ladybug stays in the range of the ugArray
                                        if (bugArray[indexBug - flightLength] == false) // check if there are another ladyBug on the new index
                                        {// if there is not, then the ladybug lands there and the while loop ends
                                            bugArray[indexBug - flightLength] = true;
                                            hasLanded = false;
                                        }
                                        else
                                        {// else the ladybug continues flying with the same length
                                            flightLength += toAdd;
                                        }
                                    }
                                    else
                                    {
                                        hasLanded = false;
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                command = Console.ReadLine().ToLower();
                                continue;
                            }
                        }

                    }
                }

                command = Console.ReadLine().ToLower();
            }
            string resultToprint = "";
            foreach(bool i in bugArray)
            {
                if(i==true)
                { 
                    resultToprint+="1"+" ";
                }
                else
                {
                    resultToprint += "0" +" ";
                }
            }
            Console.WriteLine(resultToprint.TrimEnd(' '));

        }
    }
}
