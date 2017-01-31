using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07DreamItem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('\\').ToArray();
            string month = input[0].ToLower();
            decimal mnyPrHr = decimal.Parse(input[1]);
            sbyte hrsPrDay = sbyte.Parse(input[2]);
            decimal itmPrc = decimal.Parse(input[3]);
            Dictionary<string, sbyte> dictionary = new Dictionary<string, sbyte>();
            dictionary.Add("jan", 31);
            dictionary.Add("feb", 28);
            dictionary.Add("march", 31);
            dictionary.Add("apr", 30);
            dictionary.Add("may", 31);
            dictionary.Add("june", 30);
            dictionary.Add("july", 31);
            dictionary.Add("aug", 31);
            dictionary.Add("sept", 30);
            dictionary.Add("oct", 31);
            dictionary.Add("nov", 30);
            dictionary.Add("dec", 31);

            sbyte wrkngDays = (sbyte)(dictionary[month] - 10);
            decimal mnyForMnth = (decimal)wrkngDays * hrsPrDay * mnyPrHr + ((decimal)wrkngDays * hrsPrDay * mnyPrHr>=700 ? (decimal)wrkngDays * hrsPrDay * mnyPrHr*0.1m : 0);
            if(mnyForMnth>=itmPrc)
            {
                Console.WriteLine("Money left = {0:f2} leva.", mnyForMnth-itmPrc);
            }
            else
            {
                Console.WriteLine("Not enough money. {0:f2} leva needed.", itmPrc-mnyForMnth);
            }
        }
    }
}
