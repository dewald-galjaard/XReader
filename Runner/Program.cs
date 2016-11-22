using System;
using System.Linq;
using System.Collections.Generic;
using XReader.IO;
using XReader.Parser;
using XReader.Domain;

namespace XReader.Runner
{
    class Program
    {
        /*
        * 
        * SET PATHS BELOW FIRST
        * 
        */
        const string _file_input = @"C:\<path>\data.csv";
        const string _file_output01 = @"C:\<path>\out1.csv";
        const string _file_output02 = @"C:\<path>\out2.csv";

        static AddressParser _addressParser = new AddressParser();
        static Dictionary<string, string> _addresses = new Dictionary<string, string>();
        static Dictionary<string, int> _names = new Dictionary<string, int>();

        static Writer _writer = new Writer();

        static void Main(string[] args)
        {
            // Read records
            var records = new Reader().ReadAll(_file_input);

            // Split records
            SplitRecords(records);

            // Sort and Write
            _writer.WriteAll(_file_output01, GetNamesSorted());
            _writer.WriteAll(_file_output02, GetAddressesSorted());

            Console.WriteLine("Done. Press any key to continue");
            Console.ReadLine();
        }

        /// <summary>
        /// Addresses alphabetically ascending
        /// </summary>
        /// <returns></returns>
        static IOrderedEnumerable<KeyValuePair<string, string>> GetAddressesSorted()
        {
            return _addresses.OrderBy(x => x.Key);
        }

        /// <summary>
        /// Names frequency decending, alphabetically ascending
        /// </summary>
        /// <returns></returns>
        static List<KeyValuePair<string, int>> GetNamesSorted()
        {
            return _names.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
        }

        /// <summary>
        /// Split into Names and Addresses
        /// </summary>
        /// <param name="records"></param>
        static void SplitRecords(List<Record> records)
        {
            // Itterate only once over records O(n)
            foreach (var r in records)
            {
                // Names
                if (!_names.ContainsKey(r.FirstName))
                {
                    _names.Add(r.FirstName, 1);
                }
                else
                {
                    _names[r.FirstName]++;
                }

                if (!_names.ContainsKey(r.LastName))
                {
                    _names.Add(r.LastName, 1);
                }
                else
                {
                    _names[r.LastName]++;
                }

                // Address
                var streetOnly = _addressParser.GetStreetName(r.Address);
                if (!_addresses.ContainsKey(streetOnly))
                {
                    _addresses.Add(streetOnly, r.Address);
                }
            }
        }
    }
}
