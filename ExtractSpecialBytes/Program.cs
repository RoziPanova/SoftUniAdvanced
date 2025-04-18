using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Linq;
using System.IO.Pipes;
using System.Collections.Generic;

namespace ExtractSpecialBytes
{
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";
            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }
        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            var image = new FileStream(binaryFilePath, FileMode.Open);
            List<byte> bytes = new List<byte> { };
            using (StreamReader reader = new StreamReader(bytesFilePath))
            {
                while (!reader.EndOfStream)
                {
                    bytes.Add(byte.Parse(reader.ReadLine()));
                }
            }
            var found = new List<byte>();

            var current = 0;
            while (current != -1)
            {
                current = image.ReadByte();
                foreach (var b in bytes)
                {
                    if (current == b)
                    {
                        found.Add(b);
                    }
                }
            }

            using (var file = File.Open(outputPath, FileMode.Create))
            {
                using (var writer = new BinaryWriter(file))
                {
                    writer.Write(found.ToArray());
                }
            }
        }
    }
}
