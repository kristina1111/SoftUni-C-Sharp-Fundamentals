using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine().ToLower();
            while(!command.Equals("end"))
            {
                string[] commandArray = command.Split(' ').ToArray();
                switch(commandArray[0])
                {
                    case "exchange":
                        if(int.Parse(commandArray[1])>=inputList.Count || int.Parse(commandArray[1])<0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            inputList = GetExchanged(inputList, int.Parse(commandArray[1]));
                        }
                        break;
                    case "max":
                        if (commandArray[1].Equals("odd") && !inputList.Any(e=>e%2==1))
                        {
                            Console.WriteLine("No matches");
                        }
                        else if (commandArray[1].Equals("even") && !inputList.Any(e => e % 2 == 0))
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            int indexMax = GetMaxOddOrEven(inputList, commandArray[1]);
                            Console.WriteLine(indexMax);
                        }
                        break;
                    case "min":
                        if (commandArray[1].Equals("odd") && !inputList.Any(e => e % 2 == 1))
                        {
                            Console.WriteLine("No matches");
                        }
                        else if (commandArray[1].Equals("even") && !inputList.Any(e => e % 2 == 0))
                        {
                            Console.WriteLine("No matches");
                        }

                        else
                        {
                            int indexMin = GetMinOddOrEven(inputList, commandArray[1]);
                            Console.WriteLine(indexMin);
                        }
                        break;


                    case "first":
                        if(int.Parse(commandArray[1])>inputList.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            List<int> listFirstOddOrEven = GetFirstOddOrEven(inputList,int.Parse(commandArray[1]), commandArray[2]);
                            Console.WriteLine("[{0}]", string.Join(", ", listFirstOddOrEven));
                        }
                        break;
                    case "last":
                        if (int.Parse(commandArray[1]) > inputList.Count)
                        {
                            Console.WriteLine("Invalid count");
                        }
                        else
                        {
                            List<int> listLastOddOrEven = GetLastOddOrEven(inputList, int.Parse(commandArray[1]), commandArray[2]);
                            Console.WriteLine("[{0}]", string.Join(", ", listLastOddOrEven));
                        }
                        break;



                }
                command = Console.ReadLine();
            }
            Console.WriteLine("[{0}]",string.Join(", ", inputList));
        }

        private static int GetMinOddOrEven(List<int> inputList, string oddOrEven)
        {
            int indexToReturn = 0;
            List<int> listToManipulate = string.Join(" ", inputList).Split(' ').Select(int.Parse).ToList();
            if (oddOrEven.Equals("even"))
            {
                listToManipulate.Reverse();
                indexToReturn = listToManipulate.Count - 1 - listToManipulate.IndexOf(listToManipulate.Where(e => e % 2 == 0).Min()); //.
            }
            else if (oddOrEven.Equals("odd"))
            {
                listToManipulate.Reverse();
                indexToReturn = listToManipulate.Count - 1 - listToManipulate.IndexOf(listToManipulate.Where(e => e % 2 == 1).Min()); //.Where(e => e % 2 == 1).ToList().
            }
            return indexToReturn;
        }

        private static List<int> GetLastOddOrEven(List<int> inputList, int count, string oddOrEven)
        {
            List<int> listLastOddOrEven = string.Join(" ", inputList).Split(' ').Select(int.Parse).ToList();
            if (oddOrEven.Equals("even"))
            {
                listLastOddOrEven.Reverse();
                listLastOddOrEven = listLastOddOrEven.Where(e => e % 2 == 0).ToList().Take(Math.Min(count, listLastOddOrEven.Count)).ToList();
                listLastOddOrEven.Reverse();
            }
            else
            {
                listLastOddOrEven.Reverse();
                listLastOddOrEven = listLastOddOrEven.Where(e => e % 2 == 1).ToList().Take(Math.Min(count, listLastOddOrEven.Count)).ToList();
                listLastOddOrEven.Reverse();
            }
            return listLastOddOrEven;
        }

        private static List<int> GetFirstOddOrEven(List<int> inputList, int count, string oddOrEven)
        {
            List<int> listFirstOddOrEven = string.Join(" ", inputList).Split(' ').Select(int.Parse).ToList();
            if (oddOrEven.Equals("even"))
            {
                listFirstOddOrEven = listFirstOddOrEven.Where(e => e % 2 == 0).ToList().Take(Math.Min(count, listFirstOddOrEven.Count)).ToList();
            }
            else
            {
                listFirstOddOrEven = listFirstOddOrEven.Where(e => e % 2 == 1).ToList().Take(Math.Min(count, listFirstOddOrEven.Count)).ToList();
            }
            return listFirstOddOrEven;
        }

        private static int GetMaxOddOrEven(List<int> inputList, string oddOrEven)
        {
            int indexToReturn = 0;
            List<int> listToManipulate = string.Join(" ",inputList).Split(' ').Select(int.Parse).ToList();
            if(oddOrEven.Equals("even"))
            {
                listToManipulate.Reverse();
                indexToReturn = listToManipulate.Count-1-listToManipulate.IndexOf(listToManipulate.Where(e => e % 2 == 0).Max()); //Where(e => e % 2 == 0).ToList()
            }
            else if(oddOrEven.Equals("odd"))
            {
                listToManipulate.Reverse();
                indexToReturn = listToManipulate.Count - 1 - listToManipulate.IndexOf(listToManipulate.Where(e => e % 2 == 1).Max());// Where(e => e % 2 == 1).ToList()
            }
            return indexToReturn;
        }

        static List<int> GetExchanged(List<int> inputList, int index)
        {
            List<int> listToManipulate = string.Join(" ", inputList).Split(' ').Select(int.Parse).ToList();
            List<int> resultList = listToManipulate.Skip(index+1).Take(inputList.Count - index+1).ToList();
            resultList.AddRange(listToManipulate.Take(index+1).ToList());
            return resultList;
        }
    }
}
