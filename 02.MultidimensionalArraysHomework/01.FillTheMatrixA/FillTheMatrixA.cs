using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MultidimensionalArraysHomework
{
    class FillTheMatrixA
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[4, 4];
            int index = 1;

            for (int col = 0; col < 4; col++)
            {
                for(int row = 0; row < 4; row++)
                {
                    matrix[row, col] = index;
                    index++;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
