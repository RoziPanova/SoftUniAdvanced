using System;
using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";
            CopyFile(inputFilePath, outputFilePath);
        }
        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream image = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream imageCopy = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    while ((bytesRead = image.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        imageCopy.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
