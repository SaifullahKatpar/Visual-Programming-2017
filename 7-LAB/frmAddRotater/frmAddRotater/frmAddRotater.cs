using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAddRotater
{
    public partial class frmAddRotater : Form
    {
        string[] fileText;
        string url;
        string[] imageUrls;
        int pointer = 0;
        public frmAddRotater()
        {
            InitializeComponent();


            fileText = new string[4];
            url = @"..\..\Resources\paths.txt";

            fileText = File.ReadAllLines(url);
            imageUrls = new string[4];
            for (int i = 0; i < fileText.Length; i++)
            {
                imageUrls[i] = fileText[i].Substring(8, fileText[i].Length - 16).Trim();
            }

            this.myTimer.Interval = 1000;
            this.myTimer.Start();
        }

        private void myTimer_Tick(object sender, EventArgs e)
        {
            pointer = (pointer++)%4;
            this.myPictureBox.Image = Image.FromFile(imageUrls[pointer]);

        }
    }
}
