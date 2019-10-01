using System;
using FileReaderStaff.Abstactions.Models;

namespace FileReaderStaff.Models
{
    public class Paragraph:IParagraph
    {
        public int ParNumber { get; set; }
        public string ParText { get; set; }
        public string ParFullValue { get; set; }
    }
}
