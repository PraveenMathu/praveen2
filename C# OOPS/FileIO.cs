using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir = new DirectoryInfo("c:\\Kowshik");
            //dir.Create();

            //FileInfo file = new FileInfo(@"c:\Kowshik\sample.txt");
            //file.Create();

            FileStream fs = new FileStream(@"c:\Kowshik\sample.txt", FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This text has been written to the file using file i/o  manipulation");

            sw.Close();
            fs.Close();

            Console.WriteLine("Some content is Written");

             fs = new FileStream(@"c:\Kowshik\sample.txt", FileMode.OpenOrCreate, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);
            //var content = sr.ReadToEnd();
            string lbl;
            while((lbl=sr.ReadLine())!=null)
            Console.WriteLine("{0}", lbl);

            sr.Close();
            fs.Close();

            StringBuilder sb = new StringBuilder();
            sb.Append("Hai!!!!!!!!!!!!!!!");
            Console.WriteLine("{0}", sb);


        }
    }
}
