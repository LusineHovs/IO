using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GetAllDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
         
            string[] array1 = Directory.GetDirectories(@"C:\");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("---- Directories of C: Disk----");

            foreach (string name in array1)
            {
                Console.WriteLine(name);

            }
            Console.ReadKey();
            Console.WriteLine("---- Files of C: Disk----");


            string[] array2 = Directory.GetFiles(@"C:\");
            foreach (string name in array2)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
