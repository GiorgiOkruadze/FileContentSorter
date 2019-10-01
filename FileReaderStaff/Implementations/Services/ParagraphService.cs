using System;
using System.Collections.Generic;
using System.Linq;
using FileReaderStaff.Abstactions.Models;
using FileReaderStaff.Abstactions.Services;
using FileReaderStaff.Models;

namespace FileReaderStaff.Services
{
    public class ParagraphService: IParagraphService
    {
        public IEnumerable<IParagraph> GetParagraphs(List<string> texts)
        {
            foreach(var item in texts)
            {
                yield return CreateParagraphFromString(item);
            }
        }

        public IParagraph CreateParagraphFromString(string parText)
        {
            var result = parText.Split('.').ToList();
            IParagraph paragraph = new Paragraph()
            {
                ParFullValue = parText,
                ParNumber = Convert.ToInt32(result.First()),
                ParText = result.Last()
            };
            return paragraph;
        }

    }
}
