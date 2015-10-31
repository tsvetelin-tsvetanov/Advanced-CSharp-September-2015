using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string: ");
            string input = Console.ReadLine();
            string pattern = @"([a-z])\1+";

            MatchCollection matches = Regex.Matches(input, pattern);
            for(int i = 0; i < matches.Count; i++)
            {
                string tempPattern = matches[i].ToString();
                string replace = tempPattern.First().ToString();
                Regex tempRegex = new Regex(tempPattern);
                input = tempRegex.Replace(input, replace);
            }

            Console.WriteLine(input);
        }
    }
}
