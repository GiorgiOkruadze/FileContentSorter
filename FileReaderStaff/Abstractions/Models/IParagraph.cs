using System;
namespace FileReaderStaff.Abstactions.Models
{
    public interface IParagraph
    {
        int ParNumber { get; set; }
        string ParText { get; set; }
        string ParFullValue { get; set; }
    }
}
