﻿using System;
using System.IO;
using System.IO.Compression;

namespace ZipAndExtract
{
    public class ZipAndExtract
    {
        static void Main()
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";
            ZipFileToArchive(inputFile, zipArchiveFile);
            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }
        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            using var archive = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);
            var fileName = Path.GetFileName(inputFilePath);
            archive.CreateEntryFromFile(inputFilePath, fileName);
        }
        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            using var archive = ZipFile.OpenRead(zipArchiveFilePath);
            var extraction = archive.GetEntry(fileName);    
            extraction.ExtractToFile(outputFilePath);
        }
    }
}