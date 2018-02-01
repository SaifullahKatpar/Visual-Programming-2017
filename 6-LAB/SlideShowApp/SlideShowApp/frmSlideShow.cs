using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;


using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace SlideShowApp
{
    public partial class frmSlideShow : Form
    {

        FileInfo[] pictures;
        string address = @"";
        int pictureCount = 0;
        char lastClick = 'n';
        public frmSlideShow()
        {
            InitializeComponent();
          

            this.btnBack.Image = Image.FromFile(@"..\..\..\back.png");
        }

        private void frmSlideShow_Load(object sender, EventArgs e)
        {
            // get the names of drives, e.g. C:\, D:\
            System.IO.DriveInfo[] allDrives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo d in allDrives)
            {
                this.comboBox1.Items.Add(d.Name);
            }

            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBox1.Image = Image.FromFile(@"..\..\..\welcome.jpg");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // item may be the directory name inside the drive or another directory

            address += comboBox1.SelectedItem.ToString();
            this.listBox1.Items.Clear();
            discoverFiles(address);

        }


        private void discoverFiles(string address)
        {
            //            MessageBox.Show(address);
            System.IO.DirectoryInfo curDir = new System.IO.DirectoryInfo(address);
            System.IO.DirectoryInfo[] allDir = curDir.GetDirectories();

            if (allDir.Length <= 0)
            {
                this.listBox1.Items.Add("No files");
            }
            foreach (System.IO.DirectoryInfo d in allDir)
            {
                this.listBox1.Items.Add(d.Name);
            }
            pictures = curDir.GetFiles("*.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            if (pictures.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(pictures[0].FullName);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            address += this.listBox1.SelectedItem.ToString() + @"\";
            comboBox1.Text = "";
            comboBox1.SelectedText = address;
            this.listBox1.Items.Clear();
            discoverFiles(address);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ++pictureCount;
            if (pictureCount >= pictures.Length)
                pictureCount = 0;              
            lastClick = 'n';
            pictureBox1.Image = Image.FromFile(pictures[pictureCount].FullName);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            --pictureCount;
            if (pictureCount < 0)
                pictureCount = pictures.Length - 1;

            lastClick = 'p';
            pictureBox1.Image = Image.FromFile(pictures[pictureCount].FullName);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.slideShowTimer.Interval = 500;
            this.slideShowTimer.Start();

        }

        private void slideShowTimer_Tick(object sender, EventArgs e)
        {
            if (lastClick == 'n')
            {
                ++pictureCount;
                if (pictureCount >= pictures.Length)
                    pictureCount = 0;

                pictureBox1.Image = Image.FromFile(pictures[pictureCount].FullName);
            }

            if (lastClick == 'p')
            {
                --pictureCount;
                if (pictureCount < 0)
                    pictureCount = pictures.Length - 1;
                pictureBox1.Image = Image.FromFile(pictures[pictureCount].FullName);
            }

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (pictures.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(pictures[0].FullName);
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (pictures.Length > 0)
            {
                pictureBox1.Image = Image.FromFile(pictures[pictures.Length - 1].FullName);
            }

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            this.slideShowTimer.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
    }
