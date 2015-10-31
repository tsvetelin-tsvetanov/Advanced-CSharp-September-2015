using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        private static string line;

        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("file.txt");
            StreamWriter writer = new StreamWriter("result.txt");
            int counter = 1;
            string line = reader.ReadLine();

            try
            {
                while (line != null)
                {
                    string result = counter + ": " + line;
                    writer.WriteLine(result);
                    line = reader.ReadLine();                   
                    counter++;
                }
                Console.WriteLine("The output file is in 02.LineNumbers->bin->Debug and is named" + 
                    " 'result.txt'");
                writer.Flush();
            }
            catch(Exception ex)
            {
                Console.WriteLine("File not found:");
                Console.WriteLine(ex);
            }
        }
    }
}
