using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //if(textBox1.Text != null && textBox1.Text.Length >= 3)
            //{
                XmlDocument doc = new XmlDocument();
                doc.Load(@"..\..\Xml files\Bookstore-XSD.xml");
                foreach (XmlNode node in doc.DocumentElement)
                {
//                    string name = node.Attributes[0].InnerText;
     //               if (name == textBox1.Text)
       //             {
                        foreach (XmlNode child in node.ChildNodes)
                        {
                            listView1.Items.Add(child.InnerText);
                        }
                    }
//                }
           // }else
            //{
            //    MessageBox.Show("Invalid Input");
            //    textBox1.Text = string.Empty;
            //    textBox1.Focus();
            //}
        }
    }
}
