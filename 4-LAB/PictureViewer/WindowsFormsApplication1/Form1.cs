using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPictureViewer : Form
    {
        int pointer = 0;
        string[] images = {"pic1.jpg","pic2.jpg","pic3.jpg","pic4.jpg" };
        public frmPictureViewer()
        {
            InitializeComponent();
            this.picSlideShow.ImageLocation = "C:\\Users\\saifullah\\Documents\\Visual Studio 2015\\Projects\\picDirectory\\" + images[pointer];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pointer < images.Length-1)
            {
                pointer++;
            }
            this.picSlideShow.ImageLocation = "C:\\Users\\saifullah\\Documents\\Visual Studio 2015\\Projects\\picDirectory\\" + images[pointer];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pointer > 0)
            {
                pointer--;
            }
            this.picSlideShow.ImageLocation = "C:\\Users\\saifullah\\Documents\\Visual Studio 2015\\Projects\\picDirectory\\" + images[pointer];

        }

        private void picSlideShow_Click(object sender, EventArgs e)
        {
            this.picSlideShow.ImageLocation = "C:\\Users\\saifullah\\Documents\\Visual Studio 2015\\Projects\\picDirectory\\" + images[pointer];

        }
    }
}
