using System.Text.RegularExpressions;

namespace XReader.Parser
{
    interface IAddressParser
    {
        string GetStreetName(string address);
    }

    public class AddressParser : IAddressParser
    {
        public string GetStreetName(string address)
        {
            return Regex.Replace(address, @"[\d-]", string.Empty).Trim(); 
        }
    }
}
