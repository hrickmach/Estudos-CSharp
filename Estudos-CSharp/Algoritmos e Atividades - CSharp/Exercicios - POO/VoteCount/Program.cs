using System;
using System.Collections.Generic;
using System.IO;

namespace VoteCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    Dictionary<string, int> voteCounts = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');

                        string name = line[0];
                        int votes = int.Parse(line[1]);

                        if (voteCounts.ContainsKey(name))
                        {
                            voteCounts[name] += votes;
                        }
                        else
                        {
                            voteCounts[name] = votes;
                        }
                    }

                    foreach (KeyValuePair<string, int> item in voteCounts)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}
