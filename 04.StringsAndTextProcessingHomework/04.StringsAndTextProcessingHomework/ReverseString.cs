using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string you want to reverse: ");
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();
            Array.Reverse(letters);
            foreach(char c in letters)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
