using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your text: ");
            string input = Console.ReadLine();
            string pattern = @"((?<=\s|^)([^-._\s][\w\.\-]+@[\w-]+\.[\w\.]+))";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach(Match m in matches)
            {
                Console.WriteLine(m);
            }
        }
    }
}
