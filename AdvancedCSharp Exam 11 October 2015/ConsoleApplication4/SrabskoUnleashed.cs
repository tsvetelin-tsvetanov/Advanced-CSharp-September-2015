using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class SrabskoUnleashed
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"([a-zA-Z ]+) (@[a-zA-Z ]+) ([0-9]+) ([0-9]+)";
            Dictionary<string, Dictionary<string, ulong>> dict = new Dictionary<string, Dictionary<string, ulong>>();

            while(input != "End")
            {
                try {
                    string[] matches = Regex.Split(input, pattern);
                    string performer = "#  " + matches[1];
                    string venue = matches[2].Remove(0, 1);
                    ulong ticketsPrice = ulong.Parse(matches[3]);
                    ulong ticketsCount = ulong.Parse(matches[4]);
                    ulong profit = 0;        

                    if (!dict.ContainsKey(venue))
                    {
                        dict.Add(venue, new Dictionary<string, ulong>());
                        dict[venue].Add(performer, profit);
                    }

                    if (!dict[venue].ContainsKey(performer))
                    {
                        dict[venue].Add(performer, profit);
                    }

                    dict[venue][performer] += ticketsCount * ticketsPrice;

                }
                catch(Exception ex)
                {
                }
                input = Console.ReadLine();
            }

            foreach(var pair in dict)
            {
                Console.WriteLine(pair.Key);
                foreach(var innerPair in pair.Value.OrderByDescending(c => c.Value))
                {
                    Console.WriteLine("{0} -> {1}", innerPair.Key, innerPair.Value);
                }
            }
        }
    }
}
