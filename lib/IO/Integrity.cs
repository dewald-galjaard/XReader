using System;

namespace XReader.IO
{
    public static class Integrity
    {
        public static void CheckFile(string file)
        {
            if (file == null)
            {
                throw new ArgumentNullException("file");
            }
            if (string.IsNullOrEmpty(file) || file == "\0")
            {
                throw new ArgumentException("file");
            }
            if (file == "  ")
            {
                throw new ArgumentException("file");
            }
            if (file.IndexOfAny(System.IO.Path.GetInvalidPathChars()) >= 0)
            {
                throw new ArgumentException("illegal characters in path");
            }
        }
    }
}
