using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Streams
{
    class ReadInputFile
    {
        Regex Rx { get; set; }

        public ReadInputFile()
        {
            Rx = new Regex(@"[a-zA-Z0-9]+");
        }

        public MatchCollection ReadFileNotUsing(string filePath)
        {
            StreamReader sr = null;
            MatchCollection linesInFiles;
            try
            {
                sr = new StreamReader(filePath);
                linesInFiles = Rx.Matches(sr.ReadToEnd());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                if (sr != null)
                {
                    Console.WriteLine("Finally.Close()");
                    sr.Close();
                }
            }
            return linesInFiles;
        }

        public MatchCollection ReadFileUsing(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    return Rx.Matches(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
