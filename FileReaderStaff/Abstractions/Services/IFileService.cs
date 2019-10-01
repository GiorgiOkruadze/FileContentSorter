using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace FileReaderStaff.Abstactions.Services
{
    public interface IFileService
    {
        Task<List<string>> GetSortedLinesFromFile(string filePath);
        Task WriteSortedLinesInFile(string filePath, List<string> texts);
    }
}
