using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();
            string result = null;

            foreach(char c in input)
            {
                result += "\\u" + ((int)c).ToString("X4");
            }
            Console.WriteLine(result);
        }
    }
}
