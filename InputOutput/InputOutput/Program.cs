using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputOutput
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write the name for creating file");
            string name =Console.ReadLine();
            string path = @"C:\FileStream\"+name+".txt";
            try
            {
            FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);

            StreamWriter sw = new StreamWriter(fs);
            string text = "Creation and writing has done";
            sw.Write(text);
            sw.Close();

            StreamReader sr = new StreamReader(path);
            string line ="";
            if ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
                fs.Close();
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (DirectoryNotFoundException er)
            {
                Console.WriteLine(er.Message);

            }
            
        }
    }
}
