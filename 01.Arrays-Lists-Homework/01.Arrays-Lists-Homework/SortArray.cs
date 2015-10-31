using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Arrays_Lists_Homework
{
    class SortArray
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            Array.Sort(numbers);

            foreach (int n in numbers)
            {
                Console.Write(n + " ");
            }
        }
    }
}
