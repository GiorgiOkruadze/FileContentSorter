using System;
using FileReaderStaff.Abstactions.Services;
using FileReaderStaff.Services;

namespace FileReaderStaff
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filePath = "testFile.txt";
            string sortedFilePath = "sortedTestFile.txt";

            IFileService fileService = new FileService();

            var result = fileService.GetSortedLinesFromFile(filePath).Result;
            fileService.WriteSortedLinesInFile(sortedFilePath, result);
        }
    }
}
