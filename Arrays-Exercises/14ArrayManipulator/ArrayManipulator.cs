using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            // 91/100 - Judge
            checked
            {
                List<string> inputNums = Console.ReadLine().Split(' ').ToList(); //Select(short.Parse)
                //inputNums.RemoveAt(0);

                //Console.WriteLine(inputNums[0]);
                string[] commandArray = Console.ReadLine().ToLower().Split(' ').ToArray();
                while (commandArray[0] != "print")
                {
                    string command = commandArray[0];
                    switch (command)
                    {
                        case "add":
                            inputNums.Insert(short.Parse(commandArray[1]), commandArray[2]);
                            break;
                        case "addmany":
                            for (int i = 2, k = 0; i < commandArray.Length; i++, k++)
                            {
                                inputNums.Insert(short.Parse(commandArray[1]) + k, commandArray[i]);
                            }
                            break;
                        case "contains":
                            Console.WriteLine(inputNums.IndexOf(commandArray[1]));
                            break;
                        case "remove":
                            inputNums.RemoveAt(short.Parse(commandArray[1]));
                            break;
                        case "shift":
                            short cnt = short.Parse(commandArray[1]);
                            while (cnt != 0)
                            {
                                string toRepace = inputNums[0];
                                inputNums.RemoveAt(0);
                                inputNums.Add(toRepace);   //inputNums.Insert(inputNums.Count, toRepace);
                                cnt--;
                            }
                            break;
                        case "sumpairs":
                            for (int i = 0, k = 1; i < inputNums.Count && k < inputNums.Count; i++, k++)
                            {
                                short numberToReplace = short.Parse(inputNums[i]);
                                numberToReplace += short.Parse(inputNums[k]);
                                inputNums[i] = numberToReplace.ToString();
                                inputNums.RemoveAt(k);
                            }
                            break;
                    }

                    //if (command.Equals("add"))
                    //{
                    //    inputNums.Insert(short.Parse(commandArray[1]), short.Parse(commandArray[2]));
                    //}
                    //else if (command.Equals("addmany"))
                    //{
                    //    for (int i = 2, k = 0; i < commandArray.Length; i++, k++)
                    //    {
                    //        inputNums.Insert(short.Parse(commandArray[1]) + k, short.Parse(commandArray[i]));
                    //    }
                    //}
                    //else if (command.Equals("contains"))
                    //{
                    //    Console.WriteLine(inputNums.IndexOf(short.Parse(commandArray[1])));
                    //}
                    //else if (command.Equals("remove"))
                    //{
                    //    inputNums.RemoveAt(short.Parse(commandArray[1]));
                    //}
                    //else if (command.Equals("shift"))
                    //{
                    //    short cnt = short.Parse(commandArray[1]);
                    //    while (cnt != 0)
                    //    {
                    //        short toRepace = inputNums[0];
                    //        inputNums.RemoveAt(0);
                    //        inputNums.Insert(inputNums.Count, toRepace);
                    //        cnt--;
                    //    }
                    //}
                    //else if (command.Equals("sumpairs"))
                    //{
                    //    for (int i = 0, k = 1; i < inputNums.Count && k < inputNums.Count; i++, k++)
                    //    {
                    //        inputNums[i] += inputNums[k];
                    //        inputNums.RemoveAt(k);
                    //    }
                    //}

                    commandArray = Console.ReadLine().ToLower().Split(' ').ToArray();
                }

                Console.WriteLine("[{0}]", string.Join(", ", inputNums));

            }

        }
    }
}
