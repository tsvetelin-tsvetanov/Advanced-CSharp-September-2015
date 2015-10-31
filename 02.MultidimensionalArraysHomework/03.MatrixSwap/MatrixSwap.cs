using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixSwap
{
    class MatrixSwap
    {
        static void Main(string[] args)
        {
            int matrixRow = int.Parse(Console.ReadLine());
            int matrixCol = int.Parse(Console.ReadLine());
            string[,] matrix = new string[matrixRow, matrixCol];

            for(int i = 0; i < matrixRow; i++)
            {
                for(int j = 0; j < matrixCol; j++)
                {
                    matrix[i, j] = Console.ReadLine();
                }
            }

            bool end = false;

            while (!end)
            {
                string input = Console.ReadLine();
                string[] words = input.Split(' ');
                if(words[0] == "swap" && int.Parse(words[1]) < matrixRow && 
                    int.Parse(words[2]) < matrixCol && int.Parse(words[3]) < matrixRow &&
                        int.Parse(words[4]) < matrixCol)
                {
                    int firstRow = int.Parse(words[1]);
                    int firstCol = int.Parse(words[2]);
                    int secondRow = int.Parse(words[3]);
                    int secondCol = int.Parse(words[4]);
                    string temp = matrix[firstRow, firstCol];
                    matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                    matrix[secondRow, secondCol] = temp;
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < matrix.GetLength(1); j++)
                        {
                            Console.Write(string.Format("{0} ", matrix[i, j]));
                        }
                        Console.Write(Environment.NewLine + Environment.NewLine);
                    }
                }
                else if(words[0].ToUpper() == "END")
                {
                    end = true;
                }
                else
                {
                    Console.WriteLine("Invalid Command");
                    Console.WriteLine();
                }
            }
        }
    }
}
