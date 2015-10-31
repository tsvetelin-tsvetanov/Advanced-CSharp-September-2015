using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader("text.txt");
            StreamReader wordsReader = new StreamReader("words.txt");
            StreamWriter wr = new StreamWriter("result.txt");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string line = textReader.ReadLine();
            string word = wordsReader.ReadLine();
            List<string> words = new List<string>();
            List<string> lines = new List<string>();
            

            try
            {
                while(word != null)
                {
                    words.Add(word);
                    word = wordsReader.ReadLine();
                }

                while (line != null)
                {
                    lines.Add(line);
                    line = textReader.ReadLine();
                }

                foreach (string w in words)
                {
                    foreach(string l in lines)
                    {
                        if (l.ToLower().Contains(w))
                        {
                            if (!dict.ContainsKey(w))
                            {
                                dict.Add(w, 1);
                            }
                            else
                            {
                                dict[w] += 1; 
                            }
                        }
                    }                  
                }

                foreach (KeyValuePair<string, int> item in dict.OrderByDescending(key => key.Value))
                {
                    wr.WriteLine("{0} - {1}", item.Key, item.Value);
                }
                Console.WriteLine("The output file is in 03.WordCount->bin->Debug and is named 'result.txt'");
                wr.Flush();
            }
            catch(Exception ex)
            {
                Console.WriteLine("File not found: ");
                Console.WriteLine(ex);
            }
        }
    }
}
