using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DesktopFilesCleaning
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\L.Hovsepyan\Desktop\Testing");
            foreach (FileInfo file in directory.GetFiles())
            {
                if (!file.IsReadOnly)
                {
                    file.Delete();
                }
                else
                {
                    Console.WriteLine("Unfortunately not all files has been deleted in this directory");
                }
            }
            Console.ReadKey();
        }
    }
}
