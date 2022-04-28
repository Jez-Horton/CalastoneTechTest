using System;
using System.IO;

namespace ConsoleApp
{
    public class FileOpen
    {
        FileStream stream;

        public FileStream openFile(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentException("'path' cannot be null or empty.", "path");

            try
            {
                if (stream == null) stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            }
            catch (IOException)
            {
                Console.WriteLine("Invalid File");
            }

            return stream;
        }
    }
}
