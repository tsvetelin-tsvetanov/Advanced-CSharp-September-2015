using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SeqOfEqualStrings
{
    class SeqOfEqualStrings
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            for(int i = 1; i < words.Length; i++)
            {
                if(words[i -1] == words[i])
                {
                    Console.Write(words[i - 1] + " ");
                } else
                {
                    Console.Write(words[i - 1]);
                    Console.WriteLine();
                }
            }

            if (words[words.Length - 1] == words[words.Length - 2])
            {
                Console.Write(words[words.Length - 1] + " ");
            }
            else
            {
                Console.Write(words[words.Length - 1]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
