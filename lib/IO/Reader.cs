using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using XReader.Domain;
using System.Linq;


namespace XReader.IO
{
    interface IReader
    {
        List<Record> ReadAll(string file);
    }

    public class Reader : IReader
    {
        public List<Record> ReadAll(string file)
        {
            Integrity.CheckFile(file);

            try
            {
                using (var textReader = File.OpenText(file))
                {
                    return new CsvReader(textReader).GetRecords<Record>().ToList();
                }
            }
            catch (FileNotFoundException fex)
            {
                throw fex;
            }
        }


    }
}
