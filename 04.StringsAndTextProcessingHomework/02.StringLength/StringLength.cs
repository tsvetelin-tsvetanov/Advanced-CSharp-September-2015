using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string. If it has less than 20 chars, '*' will be added"
                + " until the string is 20 chars long. IF it is longer, the first 20 chars will be shown.");
            string input = Console.ReadLine();
            if(input.Length < 20)
            {
                Console.WriteLine(input.PadRight(20, '*'));
            }
            else
            {
                for(int i = 0; i < 20; i++)
                {
                    char c = input[i];
                    Console.Write(c);
                }
            }

            Console.ReadLine();
        }
    }
}
