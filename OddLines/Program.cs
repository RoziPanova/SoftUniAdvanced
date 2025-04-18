using System;
using System.IO;
using System.Linq;
using System.Text;

namespace OddLines
{
    public class OddLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    int line = 0;
                    while (!reader.EndOfStream)
                    {
                        if (line % 2 != 0)
                        {
                            writer.WriteLine(reader.ReadLine());
                        }
                        else
                        {
                            reader.ReadLine();
                        }
                        line++;
                    }
                }
            }
        }
    }
}
