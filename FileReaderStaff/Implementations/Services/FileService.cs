using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FileReaderStaff.Abstactions.Models;
using FileReaderStaff.Abstactions.Services;
using FileReaderStaff.Extensions;
using FileReaderStaff.Models;

namespace FileReaderStaff.Services
{
    public class FileService : IFileService
    {
        public async Task<List<string>> GetSortedLinesFromFile(string filePath)
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                var splitedText = (await reader.ReadToEndAsync()).SplitOnParagraph();

                IParagraphService paragraphService = new ParagraphService();

                List<IParagraph> paragrapsCollection = paragraphService.GetParagraphs(splitedText).ToList();
                paragrapsCollection.Sort((x,y) => string.Compare(x.ParText, y.ParText, StringComparison.Ordinal));

                List<IGrouping<char,IParagraph>> groupBySymbols = paragrapsCollection
                    .GroupBy(o => o.ParText.First())
                    .ToList();

                List<List<IParagraph>> sortedGroupedCollection = new List<List<IParagraph>>();
                groupBySymbols.ForEach(o=> sortedGroupedCollection
                .Add(o.OrderBy(x=>x.ParNumber)
                .ToList()));

                return sortedGroupedCollection.SelectMany(o => o).Select(o=>o.ParFullValue).ToList();
            }
        }

        public async Task WriteSortedLinesInFile(string filePath,List<string> texts)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                var joinedResult = string.Join("\n", texts);
                await writer.WriteAsync(joinedResult);
            }
        }
    }
}
