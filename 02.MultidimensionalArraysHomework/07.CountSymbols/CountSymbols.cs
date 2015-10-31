using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountSymbols
{
    class CountSymbols
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach(char c in input)
            {
                if (symbols.ContainsKey(c))
                {
                    symbols[c]++;
                }
                else
                {
                    symbols.Add(c, 1);
                }
            }

            char[] charKeys = symbols.Keys.ToArray();

            foreach(var c in charKeys)
            {
                Console.WriteLine($"{c}: {symbols[c]} time/s");
            }
        }
    }
}
