using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BannedWords
{
    class BannedWords
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter banned words:");
            string bannedWords = Console.ReadLine();
            string[] bannedWordsArray = bannedWords.Replace(" ", "").Split(',');
            Console.WriteLine("Please enter a string:");
            string input = Console.ReadLine();

            StringBuilder builder = new StringBuilder(input);

            foreach(string str in bannedWordsArray)
            {
                str.Trim();
                Console.WriteLine(str);
                string asterisks = new string('*', str.Length);
                builder.Replace(str, asterisks);
            }

            Console.WriteLine(builder);
        }
    }
}
