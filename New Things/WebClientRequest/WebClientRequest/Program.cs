using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebClientRequest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var client = new WebClient())
            {
                var contents = client.DownloadString("https://www.facebook.com");
                Console.WriteLine(contents);

                FileInfo fi = new FileInfo(@"C:\Users\saifullah\Desktop\facebookdata.txt");
                StreamWriter sw = fi.AppendText();
                sw.WriteLine(contents);
                sw.Close();

            }
        }
    }
}
