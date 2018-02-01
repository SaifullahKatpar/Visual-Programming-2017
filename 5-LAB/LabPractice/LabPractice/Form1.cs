using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.colorDialog1.AllowFullOpen = true;
            //this.colorDialog1.ShowHelp = true;
            //this.colorDialog1.Color = label1.ForeColor;
            //if (colorDialog1.ShowDialog() ==DialogResult.OK)
            //{
            //    label1.ForeColor = colorDialog1.Color;
            //}


            //fontDialog1.ShowColor = true;
            //fontDialog1.Font = label1.Font;
            //fontDialog1.Color = label1.ForeColor;
            //if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            //{
            //    label1.Font = fontDialog1.Font;
            //    label1.ForeColor = fontDialog1.Color;
            //}


            //saveFileDialog1.Filter = "txt files (*.txt) | *.txt|All files(*.*)|*.*";
            //saveFileDialog1.FilterIndex = 2;
            //if (saveFileDialog1.ShowDialog() ==DialogResult.OK)
            //{
            //    string filename = saveFileDialog1.FileName;

            //    string[] lines = {"All lines","All lines" };

            //    File.WriteAllLines(filename,lines);
            //}


            Stream myStream;
            saveFileDialog1.Filter = "txt files (*.txt) | *.txt|All files(*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ( (myStream = saveFileDialog1.OpenFile() )!= null )
                {
                    myStream.Close();

                }
            }






        }
    }
}
