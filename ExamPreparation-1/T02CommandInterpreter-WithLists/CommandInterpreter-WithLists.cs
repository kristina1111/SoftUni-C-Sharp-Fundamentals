using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02Commandinterpreter
{
    class Commandinterpreter
    {
        static void Main(string[] args)
        {
            List<string> inputArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> resultArray = inputArray;
            string command = Console.ReadLine().ToLower();
            while (!command.Equals("end"))
            {
                int start = 0;
                int count = 0;
                string[] commandArray = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandArray[0] == "reverse" || commandArray[0] == "sort")
                {// check if the command is valid
                    if (!int.TryParse(commandArray[2], out start) || !int.TryParse(commandArray[4], out count))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    else
                    {
                        start = int.Parse(commandArray[2]);
                        count = int.Parse(commandArray[4]);
                        if (start < 0 || count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine().ToLower();
                            continue;
                        }
                        if (!(start + count <= inputArray.Count && start < inputArray.Count && count <= inputArray.Count)) //else if
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine().ToLower();
                            continue;
                        }
                        else
                        {
                            /// if the command is valid.....
                            switch (commandArray[0])
                            {
                                case "reverse":
                                    resultArray = ReverseArray(resultArray, start, count);
                                    break;
                                case "sort":
                                    resultArray = SortArray(resultArray, start, count);
                                    break;
                            }
                        }
                    }
                }
                else if (commandArray[0] == "rollleft" || commandArray[0] == "rollright")
                {
                    if (!int.TryParse(commandArray[1], out count))
                    {
                        Console.WriteLine("Invalid input parameters.");
                        command = Console.ReadLine().ToLower();
                        continue;
                    }
                    else
                    {
                        count = int.Parse(commandArray[1]);
                        if (count < 0)
                        {
                            Console.WriteLine("Invalid input parameters.");
                            command = Console.ReadLine().ToLower();
                            continue;
                        }
                        else
                        {/// if the command is valid.....
                            switch (commandArray[0])
                            {
                                case "rollleft":
                                    resultArray = RollLeftArray(resultArray, count);
                                    break;
                                case "rollright":
                                    resultArray = RollRightArray(resultArray, count);
                                    break;
                            }
                        }

                    }
                }
                command = Console.ReadLine().ToLower();

            }
            Console.WriteLine("[{0}]", string.Join(", ", resultArray));


        }

        private static List<string> RollRightArray(List<string> inputArray, int count)
        {
            List<string> resultArray = inputArray;
            for (int i = 0; i < count % resultArray.Count; i++)
            {
                string temp = resultArray[resultArray.Count - 1];
                resultArray.RemoveAt(resultArray.Count - 1);

                resultArray.Insert(0, temp);
            }
            return resultArray;
        }

        private static List<string> RollLeftArray(List<string> inputArray, int count)
        {
            List<string> resultArray = inputArray;

            for (int i = 0; i < count % resultArray.Count; i++)
            {
                string temp = resultArray[0];
                resultArray.RemoveAt(0);
                resultArray.Add(temp);
            }

            return resultArray;
        }

        private static List<string> SortArray(List<string> inputArray, int start, int count)
        {
            List<string> resultArray = inputArray;
            string[] arraySort = new string[count];
            for (int i = 0; i < count; i++)
            {
                arraySort[i] = inputArray[start + count - 1 - i];
            }
            arraySort = arraySort.OrderBy(s => s).ToArray();

            for (int i = start; i < start + count; i++)
            {
                if (i >= start && i <= start + count - 1)
                {
                    resultArray[i] = arraySort[i - start];
                }
            }
            return resultArray;
        }

        private static List<string> ReverseArray(List<string> inputArray, int start, int count)
        {
            List<string> reversedArray = inputArray;
            string[] arrayRev = new string[count];
            for (int i = 0; i < count; i++)
            {
                arrayRev[i] = inputArray[start + count - 1 - i];
            }
            for (int i = start; i < start + count; i++)
            {
                if (i >= start && i <= start + count - 1)
                {
                    reversedArray[i] = arrayRev[i - start];
                }
            }

            return reversedArray;

        }
    }
}
