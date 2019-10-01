using System;
using System.Collections.Generic;
using FileReaderStaff.Abstactions.Models;

namespace FileReaderStaff.Abstactions.Services
{
    public interface IParagraphService
    {
        IEnumerable<IParagraph> GetParagraphs(List<string> texts);
        IParagraph CreateParagraphFromString(string parText);
    }
}
