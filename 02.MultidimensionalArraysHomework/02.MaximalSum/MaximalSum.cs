using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            int matrixRow = int.Parse(array[0]);
            int matrixCol = int.Parse(array[1]);
            int[,] matrix = new int[matrixRow, matrixCol];

            for(int i = 0; i < matrixRow; i++)
            {
                input = Console.ReadLine();
                array = input.Split(' ');
                for(int j = 0; j < matrixCol; j++)
                {
                    matrix[i, j] = int.Parse(array[j]);
                }
            }

            int sum = 0;
            int maxSum = 0;
            int start = 0;
            int maxStart = 0;

            for (int i = 0; i <= matrixRow - 3; i++)
            {
                for(int j = 0; j <= matrixCol - 3; j++)
                {
                    start = j;
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] +
                        matrix[i + 1, j + 1] + matrix[i + 1, j + 2] + matrix[i + 2, j] + 
                        matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                    if(sum > maxSum)
                    {
                        maxSum = sum;
                        maxStart = start;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Sum = {0}", maxSum);
            for (int i = maxStart; i < maxStart+3; i++)
            {
                for (int j = maxStart; j < maxStart+3; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
