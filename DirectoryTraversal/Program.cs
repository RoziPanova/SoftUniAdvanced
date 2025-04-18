using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";
            var reportContent = TraverseDirectory(path);

            WriteReportToDesktop(reportContent, reportFileName);
        }
        public static Dictionary<string, List<FileInfo>> TraverseDirectory(string inputFolderPath)
        {
            Dictionary<string, List<FileInfo>> fileDirectory = new Dictionary<string, List<FileInfo>>();
            string[] files = Directory.GetFiles(inputFolderPath);
            foreach (var item in files)
            {
                FileInfo info = new FileInfo(item);
                string extension = info.Extension;
                if (fileDirectory.ContainsKey(extension) == false)
                {
                    fileDirectory.Add(extension, new List<FileInfo>());
                }
                fileDirectory[extension].Add(info);
            }
            return fileDirectory;
        }
        public static void WriteReportToDesktop(Dictionary<string, List<FileInfo>> fileDirectory, string reportFileName)
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            using StreamWriter writer = new StreamWriter(path);

            foreach (var item in fileDirectory.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                writer.WriteLine(item.Key);
                foreach (var file in item.Value.OrderBy(x => x.Length))
                {
                    writer.WriteLine($"--{file.Name} - {((double)file.Length / 1024):f3}kb");
                }
            }
        }
    }
}
