using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.SentenceExtractor
{
    class SentenceExtractor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your keyword:");
            string key = Console.ReadLine();
            Console.WriteLine("Enter your text: ");
            string input = Console.ReadLine();

            string pattern = @"[^.?!]*(?<=[.?\s!])is(?=[\s.?!])[^.?!]*[.?!]";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach(Match m in matches)
            {
                Console.WriteLine(m);
            }

        }
    }
}
