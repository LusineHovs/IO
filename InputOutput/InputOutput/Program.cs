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


            string path = @"C:\FileStream\File.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        string text = "Creation and writing has done";
                        sw.Write(text);
                        sw.Close();
                    }


                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line ="";
                        if ((line = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                        }
                    }

                    fs.Close();
                }
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
