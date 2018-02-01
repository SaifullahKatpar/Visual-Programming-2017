using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nPlease enter the URI to post data to : ");
            String uriString = "https://drive.google.com/drive/u/0/";

            // Create a new WebClient instance.
            WebClient myWebClient = new WebClient();

            Console.WriteLine("\nPlease enter the fully qualified path of the file to be uploaded to the URI");
            string fileName = @"C:\Users\saifullah\Desktop\AllSundays.txt";
            Console.WriteLine("Uploading {0} to {1} ...", fileName, uriString);

            // Upload the file to the URI.
            // The 'UploadFile(uriString,fileName)' method implicitly uses HTTP POST method.
            byte[] responseArray = myWebClient.UploadFile(uriString, fileName);

            // Decode and display the response.
            Console.WriteLine("\nResponse Received.The contents of the file uploaded are:\n{0}",
                System.Text.Encoding.ASCII.GetString(responseArray));
        }
    }
}
