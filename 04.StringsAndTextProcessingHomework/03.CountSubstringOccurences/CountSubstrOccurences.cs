using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CountSubstringOccurences
{
    class CountSubstrOccurences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();
            Console.WriteLine("Please enter a second string:");
            string substr = Console.ReadLine().ToLower();
            int count = input.Select((c, i) => input.Substring(i)).Count(x => x.StartsWith(substr,
                StringComparison.CurrentCultureIgnoreCase)); 

            Console.WriteLine(count);
            
        }
    }
}
