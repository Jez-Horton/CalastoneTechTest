using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    public class StreamEditing
    {
        StreamReader sr;
        FileOpen fileOpen;
        FileStream stream;
        public void FilterController()
        {
            fileOpen = new FileOpen();
            try
            {
                stream = fileOpen.openFile(Path.Combine(Directory.GetCurrentDirectory(), "test.txt"));
                sr = new StreamReader(stream, Encoding.UTF8);

                string line = String.Empty;
                List<char> characters = new List<char>();
                while ((line = sr.ReadLine()) != null)
                {
                    List<string> words = line.Split(' ').ToList();

                    words.RemoveAll(HasLength);
                    words.RemoveAll(ContainsLetter);

                    Console.WriteLine(words.Aggregate((a, b) => a + " " + b));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(Path.Combine(Directory.GetCurrentDirectory(), "test.txt"));
            }
        }
        public void FilterLetter(List<char> chars = null, bool position = true)
        {

        }
        public bool HasLength(string s)
        {
            return (s.ToLower().Length < 3);
        }
        public bool ContainsLetter(string s)
        {
            return (s.ToLower().Contains("t"));
        }
    }
}
