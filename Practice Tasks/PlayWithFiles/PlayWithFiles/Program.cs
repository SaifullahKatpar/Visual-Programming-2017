using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {

            //FileInfo fi = new FileInfo(@"C:\Users\saifullah\Desktop\temp.txt");
            //StreamWriter sw = fi.AppendText();
            //sw.WriteLine("Hello");
            //sw.WriteLine("World");
            //sw.Close();

            //---------
            string path = @"C:\Users\saifullah\Desktop\temp.txt";
            FileInfo file = new FileInfo(path);
            using (StreamReader sr = file.OpenText())
            {
                string s = "";
                while ( (s = sr.ReadLine())!=null)
                {
                    Console.WriteLine(s);
                }
            } 



        }
    }
}
