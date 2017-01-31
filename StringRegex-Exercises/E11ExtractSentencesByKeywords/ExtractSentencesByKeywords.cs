using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace E11ExtractSentencesByKeywords
{
    class ExtractSentencesByKeywords
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string inputAll = Console.ReadLine();
            string pattern = @"(?<=^| |(! )|(\? )|(\. ))[\w-]+([,\- \t\n\:\(\)\[\]\\\/]+[\w-]+){0,}(?=\.|!|\?)";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(inputAll);
            string patternForPrintSent = @"\b" + keyWord.Trim() + @"\b"; //(?:^|\s)to(?:$|\.| |!|\?)
            Regex rgxForPrintSent = new Regex(patternForPrintSent);
            foreach (Match m in matches)
            {
                if (Regex.IsMatch(m.ToString(), string.Format(patternForPrintSent)))
                {
                    Console.WriteLine(m.Groups[0]);
                }
            }

            //string[] SentArray = inputAll.Split(new[] { '!', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //foreach(string s in SentArray)
            //{
            //    string[] words = s.Split(new[] { ' ', ',', '\t', ':', '(', ')', '\\', '/', '"', ']', '[' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    foreach(string w in words)
            //    {
            //        if(w.Equals(keyWord))
            //        {
            //            Console.WriteLine(s.Trim(new[] { ' ','!', '.', '?' }));
            //        }
            //    }
            //}
        }
    }
}
