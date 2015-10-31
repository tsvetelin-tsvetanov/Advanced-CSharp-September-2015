using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CategorizeNumbers
{
    class CategorizeNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] numbers = input.Split(' ');
            List<double> floatNumbers = new List<double>();
            List<double> roundNumbers = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(Double.Parse(numbers[i]) % 1 == 0)
                {
                    roundNumbers.Add(Double.Parse(numbers[i]));
                }
                else
                {
                   floatNumbers.Add(Double.Parse(numbers[i]));
                }
            }

            Console.Write("[");
            foreach(double n in floatNumbers)
            {
                Console.Write(n + " ");
            }
            Console.Write("] -> min: {0}, max: {1}, sum:{2}, avg: {3:F2}",
                floatNumbers.Min(), floatNumbers.Max(), floatNumbers.Sum(), 
                floatNumbers.Average());
            Console.WriteLine();

            Console.Write("[");
            foreach (double n in roundNumbers)
            {
                Console.Write(n + " ");
            }
            Console.Write("] -> min: {0}, max: {1}, sum:{2}, avg: {3:F2}",
                roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(),
                roundNumbers.Average());
            Console.WriteLine();

        }
    }
}
