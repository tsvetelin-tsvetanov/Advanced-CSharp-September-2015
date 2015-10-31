using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();
            string[] words = Regex.Split(input, @"\W");
            List<string> palindromes = new List<string>();

            for(int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                string word2 = new string(word.ToCharArray().Reverse().ToArray());
                if(word == word2)
                {
                    palindromes.Add(word);
                }
            }

            palindromes.Sort();

            foreach(string word in palindromes)
            {
                Console.WriteLine(word);
            }
        }
    }
}
