using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FileReaderStaff.Extensions
{
    public static class StringExtensions
    {
        public static List<string> SplitOnParagraph(this string text)
        {
            return SplitOnSymbols(text, "\r\n|\r|\n");
        }

        public static List<string> SplitOnSymbols(this string text,string separator)
        {
            return Regex.Split(text, separator).ToList();
        }
    }
}
