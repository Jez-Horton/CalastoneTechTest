using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamEditing streamEditing = new StreamEditing();
            Console.WriteLine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName);
            Console.ReadKey();
        }
    }
}
