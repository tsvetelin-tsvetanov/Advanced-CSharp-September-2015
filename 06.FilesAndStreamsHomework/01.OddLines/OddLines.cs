using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            string input;
            List<string> lines = new List<string>();
            int counter = 0;
            StreamReader reader = new StreamReader("file.txt");

            try
            {
                while((input = reader.ReadLine()) != null)
                {
                    lines.Add(input);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("All lines:");
                string[] linesArr = new string[lines.Count];
                foreach(string line in lines)
                {
                    linesArr[counter] = line;
                    Console.WriteLine(line);
                    counter++;
                }

                Console.WriteLine();
                Console.WriteLine("Odd lines:");
                for(int i = 0; i < linesArr.Length; i+=2)
                {
                    Console.WriteLine(linesArr[i]);
                }
            }
        }
    }
}
