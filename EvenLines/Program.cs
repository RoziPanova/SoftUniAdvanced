using System;
using System.IO;

namespace EvenLines
{
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            Console.WriteLine(ProcessLines(inputFilePath)); 
        }
        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int lines = 0;
                while (!reader.EndOfStream)
                {
                    if (lines % 2 == 0)
                    {
                        string[] words = reader.ReadLine().Split(" ");
                        for (int i = words.Length - 1; i >= 0; i--)
                        {
                            if (words[i].Contains('-'))
                            {
                                words[i] = words[i].Replace('-', '@');
                            }
                            else if (words[i].Contains(','))
                            {
                                words[i] = words[i].Replace(',', '@');
                            }
                            else if(words[i].Contains('.'))
                            {
                                words[i] = words[i].Replace('.', '@');
                            }
                            else if(words[i].Contains('!'))
                            {
                                words[i] = words[i].Replace('!', '@');
                            }
                            else if(words[i].Contains('?'))
                            {
                                words[i] = words[i].Replace('?', '@');
                            }
                            Console.Write(words[i] + " ");
                        }
                        Console.WriteLine();

                    }
                    else
                    {
                        reader.ReadLine();
                    }
                    lines++;
                }
                return "";
            }
        }
    }
}
