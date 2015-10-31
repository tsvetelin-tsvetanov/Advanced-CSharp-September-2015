using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Bunnies
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            char[,] maze = new char[rows, cols];
            int playerRow = 0;
            int playerCol = 0;

            for(int i = 0; i < rows; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for(int j = 0; j < cols; j++)
                {
                    maze[i, j] = input[j];
                    if(input[j] == 'P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }

            char[] moves = Console.ReadLine().ToCharArray();

            foreach(char move in moves)
            {
                switch (move)
                {
                    case 'U':
                        playerRow--;
                        break;
                    case 'D':
                        playerRow++;
                        break;
                    case 'L':
                        playerCol--;
                        break;
                    case 'R':
                        playerCol++;
                        break;
                }

                for(int i = 0; i < rows; i++)
                {
                    for(int j = 0; j < cols; j++)
                    {
                        if(maze[i, j] == 'B')
                        {
                            try
                            {
                                maze[i, j - 1] = 'B';
                            }
                            catch(Exception ex){}
                            try
                            {
                                maze[i, j + 1] = 'B';
                            }
                            catch (Exception ex){}
                            try
                            {
                                maze[i - 1, j] = 'B';
                            }
                            catch (Exception ex){}
                            try
                            {
                                maze[i + 1, j] = 'B';
                            }
                            catch (Exception ex){}
                        }
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(maze[i, j]);
                }
                Console.WriteLine();
            }

        }      
    }
}
