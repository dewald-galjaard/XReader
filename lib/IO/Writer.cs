using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using System;

namespace XReader.IO
{
    public class Writer
    {
        public void WriteAll(string file, IOrderedEnumerable<KeyValuePair<string, string>> records)
        {
            Integrity.CheckFile(file);

            using (TextWriter textWriter = File.CreateText(file))
            {
                /*
                 * Turns out CsvWriter is buggy.
                 * 
                var csv = new CsvWriter(textWriter);
                csv.WriteRecords(list);
                */

                foreach(var record in records.ToList())
                {
                    if(record.Value != null)
                        textWriter.WriteLine(record.Value);
                }
            }
            
        }

        public void WriteAll(string file, List<KeyValuePair<string, int>> records)
        {
            Integrity.CheckFile(file);

            using (TextWriter textWriter = File.CreateText(file))
            {
                var csvWriter = new CsvWriter(textWriter);
                foreach (var item in records)
                {
                    csvWriter.WriteRecord(item);
                }
            }
        }
    }
}
