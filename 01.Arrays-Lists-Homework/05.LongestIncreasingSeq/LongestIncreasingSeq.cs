using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.LongestIncreasingSeq
{
    class LongestIncreasingSeq
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            int end = 0;
            int len = 1;
            int bestLen = 1;

            Console.Write(numbers[0] + " ");
            for(int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] < numbers[i])
                {
                    Console.Write(numbers[i] + " ");
                    len++;
                } 
                else
                {
                    len = 1;
                    Console.WriteLine();
                    Console.Write(numbers[i] + " ");
                }
                if (bestLen < len)
                {
                    bestLen = len;
                    end = i;
                }
            }
            Console.WriteLine();

            Console.Write("Longest: ");
            for(int i = end - bestLen + 1; i <= end; i++)
            {
                Console.Write(numbers[i] + " ");
            }
        }
    }
}
