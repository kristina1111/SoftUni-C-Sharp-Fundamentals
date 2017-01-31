using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E17EncryptTheMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            //string start = Console.ReadLine();
            string input = Console.ReadLine();
            int msgCnt = 0;
            List<string> output = new List<string>();
            while (input != "START" && input != "start")
            {
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "end" && input != "END") 
            {
                if(input == "")
                {
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    msgCnt++;
                    StringBuilder input2 = new StringBuilder(input);
                    for(int i = 0; i<input.Length; i++)
                    {
                        if((input[i] >='A' && input[i]<='M') || (input[i] >= 'a' && input[i] <= 'm'))
                        {
                            input2[i] = (char)(input[i] + 13);
                        }
                        else if((input[i]>='N' && input[i]<='Z') || (input[i] >= 'n' && input[i] <= 'z'))
                        {
                            input2[i] = (char)(input[i] - 13);
                        }
                        else if(input[i] == ' ')
                        {
                            input2[i] = '+';
                        }
                        else if(input[i] == ',')
                        {
                            input2[i] = '%';
                        }
                        else if(input[i] == '.')
                        {
                            input2[i] = '&';
                        }
                        else if(input[i] == '?')
                        {
                            input2[i] = '#';
                        }
                        else if(input[i] == '!')
                        {
                            input2[i] = '$';
                        }
                        else
                        {
                            input2[i] = input[i];
                        }
                    }
                    string encrypted = input2.ToString();
                    output.Add(encrypted);
                }
                input = Console.ReadLine();
            }
            if(msgCnt == 0)
            {
                Console.WriteLine("No messages sent.");
            }
            else
            {
                Console.WriteLine("Total number of messages: {0}", msgCnt);
                foreach (string i in output)
                {
                    Console.WriteLine(new string(i.Reverse().ToArray()));
                }
            }
            
        }
    }
}
