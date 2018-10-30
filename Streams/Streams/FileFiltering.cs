using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Streams
{
    class FileFiltering
    {
        public IGrouping<string, Match> GetWord(MatchCollection fileText, int wordLength, int nthElement)
        {
            return fileText
                .Where(x => x.Length > wordLength)
                .GroupBy(x => x.Value, StringComparer.InvariantCultureIgnoreCase)
                .OrderByDescending(x => x.Count())
                .ElementAt(nthElement);
        }

        public int GetWordCount(MatchCollection fileText, string searchTerm)
        {
            return fileText
                .Count(x => x.Value == searchTerm);
        }
    }
}
