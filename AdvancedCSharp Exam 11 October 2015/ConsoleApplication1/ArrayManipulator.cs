using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] tempArr = input.Split(' ');
            int[] numbers = new int[tempArr.Length];
            for (int i = 0; i < tempArr.Length; i++)
            {
                numbers[i] = int.Parse(tempArr[i]);
            }

            string command = Console.ReadLine();
            while (command != "end")
            {
                SwitchCommands(command, numbers);
                command = Console.ReadLine();
            }

            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }

        private static void SwitchCommands(string command, int[] numbers)
        {
            string[] commandElements = command.Split(' ');
            switch (commandElements[0])
            {
                case "exchange":
                    ExchangeElements(int.Parse(commandElements[1]), numbers);
                    break;
                case "max":
                    GetMaxNumber(commandElements[1], numbers);
                    break;
                case "min":
                    GetMinNumber(commandElements[1], numbers);
                    break;
                case "first":
                    FirstCountElements(int.Parse(commandElements[1]), numbers, commandElements[2]);
                    break;
                case "last":
                    LastCountElements(int.Parse(commandElements[1]), numbers, commandElements[2]);
                    break;
            }
        }

        private static void LastCountElements(int index, int[] numbers, string comm)
        {
            if (index > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> tempList = new List<int>();
            if (comm == "odd")
            {
                foreach (int n in numbers)
                {
                    if (n % 2 != 0)
                    {
                        tempList.Add(n);
                    }
                }
            }
            else
            {
                foreach(int n in numbers)
                {
                    if (n % 2 == 0)
                    {
                        tempList.Add(n);
                    }
                }
            }

            List<int> result = tempList.Skip(tempList.Count - index).Take(index).ToList();            

            if (tempList.Count > 0)
            {      
                Console.WriteLine("[" + string.Join(", ", result) + "]");
                tempList.Clear();
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        private static void FirstCountElements(int index, int[] numbers, string comm)
        {
            if (index > numbers.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            List<int> tempList = new List<int>();
            if (comm == "odd")
            { 
                foreach(int n in numbers)
                {
                    if(n % 2 != 0)
                    {
                        tempList.Add(n);                       
                    }
                }
            }
            else
            {
                foreach (int n in numbers)
                {
                    if (n % 2 == 0)
                    {
                        tempList.Add(n);
                    }
                }
            }

            List<int> result = tempList.Take(index).ToList();

            if (tempList.Count > 0)
            {
                Console.WriteLine("[" + string.Join(", ", result) + "]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        private static void GetMinNumber(string comm, int[] numbers)
        {
            List<int> tempList = new List<int>();
            int minIndex = 0;
            if (comm == "odd")
            {
                foreach (int n in numbers)
                {
                    if (n % 2 != 0)
                    {
                        tempList.Add(n);
                    }
                }

                if (tempList.Count > 0)
                {
                    minIndex = tempList.Min();
                    
                    Console.WriteLine(Array.LastIndexOf(numbers, minIndex));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                foreach (int n in numbers)
                {
                    if (n % 2 == 0)
                    {
                        tempList.Add(n);
                    }
                }

                if (tempList.Count > 0)
                {
                    minIndex = tempList.Min();
                    Console.WriteLine(Array.LastIndexOf(numbers, minIndex));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void GetMaxNumber(string comm, int[] numbers)
        {
            List<int> tempList = new List<int>();
            int maxIndex = 0;
            if(comm == "odd")
            {
                foreach(int n in numbers)
                {
                    if(n % 2 != 0)
                    {
                        tempList.Add(n);
                    }
                }

                if(tempList.Count > 0)
                {
                    maxIndex = tempList.Max();
                    Console.WriteLine(Array.LastIndexOf(numbers, maxIndex));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                foreach (int n in numbers)
                {
                    if (n % 2 == 0)
                    {
                        tempList.Add(n);
                    }
                }

                if (tempList.Count > 0)
                {
                    maxIndex = tempList.Max();
                    Console.WriteLine(Array.LastIndexOf(numbers, maxIndex));
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void ExchangeElements(int index, int[] numbers)
        {
            if(index > numbers.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            var tempArr1 = numbers.Take(index + 1).ToArray();
            var tempArr2 = numbers.Skip(index + 1).Take(numbers.Length - index).ToArray();
            var tempArr3 = new int[tempArr1.Length + tempArr2.Length];
            tempArr2.CopyTo(tempArr3, 0);
            tempArr1.CopyTo(tempArr3, tempArr2.Length);

            for(int i = 0; i < tempArr3.Length; i++)
            {
                numbers[i] = tempArr3[i];
            }

        }
    }
}
