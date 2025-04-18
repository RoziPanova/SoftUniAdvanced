using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            CalculateWordCounts(wordPath, textPath, outputPath);
        }
        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            using (StreamReader text = new StreamReader(textFilePath))
            {
                using (StreamReader words = new StreamReader(wordsFilePath))
                {
                    using (StreamWriter output = new StreamWriter(outputFilePath))
                    {
                        Dictionary<string, int> count = new Dictionary<string, int>();

                        string[] word = words.ReadLine().ToString().ToLower().Split(" ").ToArray();
                        while (!text.EndOfStream)
                        {
                            string current = text.ReadLine().ToLower();
                            foreach (var item in word)
                            {
                                if (current.Contains(item))
                                {
                                    if (count.ContainsKey(item) == false)
                                    {
                                        count[item] = 1;
                                    }
                                    else
                                    {
                                        count[item] += 1;
                                    }
                                }
                            }
                        }
                        var sorted=count.OrderByDescending(x => x.Value);
                        foreach (var item in sorted)
                        {
                            output.WriteLine($"{item.Key} - {item.Value}");
                        }
                    }
                }
            }
        }
    }
}
