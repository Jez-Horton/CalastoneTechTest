using System;
using System.IO;

namespace ConsoleApp
{
    public class FileOpen
    {
        public FileStream Stream { get; private set; }

        public FileOpen(string path)
        {
            if (string.IsNullOrEmpty(path)) throw new ArgumentException("'path' cannot be null or empty.", "path");

            try
            {
                if (Stream == null) Stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("You do not have access to that file");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Invalid File");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex);

            }
            Stream = Stream;
        }
    }
}
