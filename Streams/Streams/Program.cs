using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\UBS\Dev\";
            string readFileName = "originofspecies.txt";
            MatchCollection linesInFiles = new ReadInputFile().ReadFileNotUsing(Path.Combine(path, readFileName));

            Console.WriteLine("totalWords in file ->" + linesInFiles.Count());

            if (linesInFiles != null)
            {
                var fileFilter = new FileFiltering();

                var nTh = 12;
                IGrouping<string, Match> getnthMostUsedWord = fileFilter.GetWord(linesInFiles, 0, nTh);
                Console.WriteLine($"{nTh + 1}th most used word -> {getnthMostUsedWord.Key} used {getnthMostUsedWord.Count()} times");

                var wordLength = 5;
                IGrouping<string, Match> getMostUsedWord = fileFilter.GetWord(linesInFiles, wordLength, 0);
                Console.WriteLine($"The most used word longer than {wordLength} characters -> {getMostUsedWord.Key} used {getMostUsedWord.Count()} times");

                string searchTerm = "varieties";
                var getStringCount = fileFilter.GetWordCount(linesInFiles, searchTerm);
                Console.WriteLine($"{searchTerm} occurs {getStringCount} times.");

                string writeFileName = "WordsLongetThenSeven.txt";
                new WriteAFile().WriteATextFile(linesInFiles, Path.Combine(path, writeFileName), 7);

                Console.ReadLine();
            }
        }
    }
}
