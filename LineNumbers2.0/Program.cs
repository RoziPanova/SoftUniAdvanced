using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";
            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {

            string[] lines = File.ReadAllLines(inputFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = lines[i].Where(char.IsLetter).Count();
                int punctuationCount = lines[i].Where(char.IsPunctuation).Count();
                lines[i] = $"Line {i + 1}: {lines[i]} ({letterCount})({punctuationCount})";
            }
            File.WriteAllLines(outputFilePath, lines);
        }
    }
}
