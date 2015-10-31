using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FirstLargerThanNeighbour
{
    class FirstLargerThanNeighbour
    {
        static void Main()
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };

            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
        }

        static int GetIndexOfFirstElementLargerThanNeighbours(int[] testArr)
        {
            int index = -1;
            for (int i = 0; i < testArr.Length; i++)
            {
                if (i == 0)
                {
                    if (testArr[i] > testArr[i + 1])
                    {
                        index = i;
                        break;
                    }
                }
                else if (i == testArr.Length - 1)
                {
                    if (testArr[i] > testArr[i - 1])
                    {
                        index = i;
                        break;
                    }
                }
                else
                {
                    if (testArr[i] > testArr[i - 1] && testArr[i] > testArr[i + 1])
                    {
                        index = i;
                        break;
                    }
                }
            }

            return index;
        }
    }
}