using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;

namespace Streams
{
    public class WriteAFile
    {
        public void WriteATextFile(MatchCollection textFile, string pathToWrite, int worldLength){

            IEnumerable<string> textToWrite = textFile.Where(x => x.Count() > worldLength);

            try
            {
                using(StreamWriter streamWriter = new StreamWriter(pathToWrite, true))
                {
                    foreach (var text in textToWrite)
                        streamWriter.Write(text + Environment.NewLine);
                }
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
