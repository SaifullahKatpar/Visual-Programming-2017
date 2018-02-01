using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gmailLoginPage
{
    public partial class GmailForm : Form
    {
        private const string _client_id = "";
        private const string _client_secret = "";

        public GmailForm()
        {
          
            InitializeComponent();

            try
            {
                HtmlDocument doc = webBrowser.Document;
                HtmlElement username = doc.GetElementById("Email");
                HtmlElement password = doc.GetElementById("Passwd");
                HtmlElement submit = doc.GetElementById("signIn");
                username.SetAttribute("value", "saifullah.cs14@iba-suk.edu.pk");
                password.SetAttribute("value", "saif666?");
                submit.InvokeMember("click");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erroe " + ex.Message);
            }


        }


        private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}
