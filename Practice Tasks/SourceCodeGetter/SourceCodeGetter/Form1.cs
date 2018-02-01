using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCodeGetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<String> getURLs(string url)
        {
            List<String> urls = new List<string>();
            string htmlSource = "";
            string pattern = "";
            htmlSource = getHTML(url);
            pattern = @"<a href=[\S]*;index=[\d]*";
            Regex regex = new Regex(pattern);
            Match m = regex.Match(htmlSource);
            string urlText = "";
            while (m.Success)
            {
                urlText = m.Value.Substring(9);
                urls.Add(urlText.Split(';')[0]);
                m = m.NextMatch();
            }
            return urls;
        }

        public string getHTML(string url)
        {
            //Create request for given url
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);

            //Create response-object
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Take response stream
            StreamReader sr = new StreamReader(response.GetResponseStream());

            //Read response stream (html code)
            string html = sr.ReadToEnd();

            //Close streamreader and response
            sr.Close();
            response.Close();

            //return source
            return html;
        }
    }
}
