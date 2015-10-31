using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class ShmoogleCounter
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToString();
            string text = null; 
            string patternDoubles = @"double ([a-zA-Z0-9]+)";
            string patternInts = @"int ([a-zA-Z0-9]+)";
            
            List<string> doublesList = new List<string>();
            List<string> intsList = new List<string>();

            while (input != "//END_OF_CODE")
            {
                text += input.Trim() + ' ';

                input = Console.ReadLine();
            }

            MatchCollection doubles = Regex.Matches(text, patternDoubles);
            MatchCollection ints = Regex.Matches(text, patternInts);

            foreach (Match m in doubles)
            {
                string found = m.ToString().Remove(0, 7);
                //if (!doublesList.Contains(found))
                //{
                    doublesList.Add(found);
                //}
                
            }

            foreach (Match m in ints)
            {
                string found = m.ToString().Remove(0, 4);
                //if (!doublesList.Contains(found))
                //{
                    intsList.Add(found);
                //}

            }

            if(doublesList.Count > 0)
            {
                doublesList.Sort();
                Console.WriteLine("Doubles: " + string.Join(", ", doublesList));
            }
            else
            {
                Console.WriteLine("Doubles: None");
            }

            if (intsList.Count > 0)
            {
                intsList.Sort();
                Console.WriteLine("Ints: " + string.Join(", ", intsList));
            }
            else
            {
                Console.WriteLine("Ints: None");
            }

        }
    }
}
