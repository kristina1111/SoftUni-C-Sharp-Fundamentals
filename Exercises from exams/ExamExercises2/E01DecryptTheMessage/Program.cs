using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01DecryptTheMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "START" && input != "start")
            {
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            List<string> inputList = new List<string>();
            int cntMsg = 0;
            while (input != "END" && input != "end")
            {
                if (string.IsNullOrEmpty(input))
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    cntMsg++;
                    StringBuilder input2 = new StringBuilder(input);
                    for (int i = 0; i < input.Length; i++)
                    {
                        if ((input[i] >= 'A' && input[i] <= 'M') || (input[i] >= 'a' && input[i] <= 'm'))
                        {
                            input2[i] = (char)(input[i] + 13);
                        }
                        else if((input[i] >= 'N' && input[i] <= 'Z') || (input[i] >= 'n' && input[i] <= 'z'))
                        {
                            input2[i] = (char)(input[i] - 13);
                        }
                        else
                        {
                            //if(input[i] == '+')
                            //{
                            //    input2[i] = ' ';
                            //}
                            //else if(input[i] == '%')
                            //{
                            //    input2[i] = ',';
                            //}
                            //else if (input[i] == '&')
                            //{
                            //    input2[i] = '.';
                            //}
                            //else if (input[i] == '#')
                            //{
                            //    input2[i] = '?';
                            //}
                            //else if (input[i] == '$')
                            //{
                            //    input2[i] = '!';
                            //}
                            //else
                            //{
                            //    input2[i] = input[i];
                            //}
                            switch (input[i])
                            {
                                case '+': input2[i] = ' '; break;
                                case '%': input2[i] = ','; break;
                                case '&': input2[i] = '.'; break;
                                case '#': input2[i] = '?'; break;
                                case '$': input2[i] = '!'; break;
                                default: input2[i] = input[i]; break;
                            }
                        }
                    }
                    input = input2.ToString();
                    inputList.Add(new string(input.Reverse().ToArray()));

                }
                input = Console.ReadLine();
            }
            if(cntMsg==0)
            {
                Console.WriteLine("No message received.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", cntMsg);
                foreach (string i in inputList)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
    }
}
