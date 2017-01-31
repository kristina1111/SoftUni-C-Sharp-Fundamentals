using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ApendLists
{
    class ApendLists
    {
        static void Main(string[] args)
        {
            string[] listArr = Console.ReadLine().Split('|').ToArray();
            string toPrint = "";
            for(int i = listArr.Length-1; i>=0; i--)
            {
                List<string> listInArr = listArr[i].Split(' ').ToList();
                for(int k = 0; k<listInArr.Count; k++)
                {
                    if(listInArr[k] == "")
                    {
                        continue;
                    }
                    toPrint += listInArr[k] + (k != listInArr.Count-1 ? " " : "");
                } 
                toPrint = toPrint.TrimEnd(new char[] { ' ' });
                toPrint += (i != 0 ? " ":"");
            }
            Console.WriteLine(toPrint);
        }
    }
}
