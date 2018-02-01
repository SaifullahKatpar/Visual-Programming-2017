using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EmailRetriever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        public void GetAllMails()
        {
            WebClient objectClient = new WebClient();
            string response = null;
            XmlDocument xdoc = new XmlDocument();

            try
            {
                objectClient.Credentials = new NetworkCredential(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                response = Encoding.UTF8.GetString(objectClient.DownloadData("https//mail.google.com/mail/feed/atom"));
                response = response.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\" >","<feed>");

                xdoc.LoadXml(response);

                if (Variables.mailcount > 0)
                {
                    Variables.emailfrom = new string[Variables.mailcount - 1];
                    Variables.emailMessages = new string[Variables.mailcount -1];
                    foreach (XmlNode node1 in xdoc.SelectNodes("feed/entry"))
                    {
                        this.listBox1.Items.Add(node1.SelectSingleNode("title").InnerText);
                    }


                }



            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message); 
            }

        }

        public void Getfeeds()
        {
            WebClient objectClient = new WebClient();
            XmlNodeList nodeList = default(XmlNodeList);
            XmlNode node = default(XmlNode);
            XmlNode node2 = default(XmlNode);
            string response = null;
            string tagline = "";
            string message_author = "";
            string message_subject= "";
            string message_summary = "";
            XmlDocument xdoc = new XmlDocument();

            try
            {
                objectClient.Credentials = new NetworkCredential(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                response = Encoding.UTF8.GetString(objectClient.DownloadData("https://mail.google.com/mail/feed/atom"));
                response = response.Replace("<feed version=\"0.3\" xmlns=\"http://purl.org/atom/ns#\" >", "<feed>");

                xdoc.LoadXml(response);

                node = xdoc.SelectSingleNode("feed/fullcount/");
                Variables.mailcount = Convert.ToInt16(node.InnerText);
                MessageBox.Show("Currently we have  " + Variables.mailcount + " emails" );

                tagline = xdoc.SelectSingleNode("feed/tagline").InnerText;

                MessageBox.Show("Sir, you have " + tagline);
                if (Variables.mailcount > 0)
                {
                    node2 = xdoc.SelectSingleNode("feed").SelectSingleNode("entry");
                    message_subject = node2.SelectSingleNode("title").InnerText;
                    message_author = node2.SelectSingleNode("auhtor").SelectSingleNode("name").InnerText;
                    message_summary = node2.SelectSingleNode("summary").InnerText;

                    MessageBox.Show("sir, a message from "+ message_author.ToString());
                    MessageBox.Show("the subject is " + message_subject.ToString() );
                    MessageBox.Show("the summary of message is ");
                    MessageBox.Show(message_summary.ToString());

                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            Getfeeds();
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            GetAllMails();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
