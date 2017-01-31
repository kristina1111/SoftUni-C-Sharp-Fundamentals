using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02Commandinterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] resultArray = inputArray;
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
                        else if (!(start + count < inputArray.Length-1))
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

        private static string[] RollRightArray(string[] inputArray, int count)
        {
            string[] resultArray = inputArray;
            for(int i =0; i<count%resultArray.Length; i++)
            {
                string temp = resultArray[resultArray.Length-1];
                for(int k = resultArray.Length - 2; k >= 0; k--)
                {
                    resultArray[k+1] = resultArray[k];
                }
                resultArray[0] = temp;
            }
            return resultArray;
        }

        private static string[] RollLeftArray(string[] inputArray, int count)
        {
            string[] resultArray = inputArray;
            
            for(int i =0; i<count % resultArray.Length; i++)
            {
                string temp = resultArray[0];
                for (int k = 1; k<resultArray.Length; k++)
                {
                    resultArray[k - 1] = resultArray[k];
                }
                resultArray[resultArray.Length - 1] = temp;
            }

            return resultArray;
        }

        private static string[] SortArray(string[] inputArray, int start, int count)
        {
            string[] resultArray = inputArray;
            string[] arraySort = new string[count];
            for (int i = 0; i < count; i++)
            {
                arraySort[i] = inputArray[start + count -1 - i];
            }
            arraySort = arraySort.OrderBy(s => s).ToArray();

            for (int i = start; i < start + count; i++) //-1
            {
                //if (i < start)
                //{
                //    resultArray[i] = inputArray[i];
                //}
                if (i >= start && i <= start + count-1) 
                {
                    resultArray[i] = arraySort[i - start];
                }
                //else
                //{
                //    resultArray[i] = inputArray[i];
                //}
            }


            return resultArray;
        }

        private static string[] ReverseArray(string[] inputArray, int start, int count)
        {
            string[] reversedArray = inputArray;
            string[] arrayRev = new string[count];
            for (int i = 0; i < count; i++)
            {
                arrayRev[i] = inputArray[start + count -1 - i];
            }
            for (int i = start; i < start + count; i++)
            {
                //if (i < start)
                //{
                //    reversedArray[i] = inputArray[i];
                //}
                if (i >= start && i <= start + count-1)
                {
                    reversedArray[i] = arrayRev[i - start];
                }
                //else
                //{
                //    reversedArray[i] = inputArray[i];
                //}
            }

            return reversedArray;

        }
    }
}
