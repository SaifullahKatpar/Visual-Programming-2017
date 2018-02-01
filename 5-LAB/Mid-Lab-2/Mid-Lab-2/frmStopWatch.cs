using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mid_Lab_2
{
    public partial class frmStopWatch : Form
    {
        DateTime time = new DateTime();
        public frmStopWatch()
        {
            InitializeComponent();
            // initially
          
            lblSec.Text = time.ToString("ss");
            lblMin.Text = time.ToString("mm");
            lblHour.Text = time.ToString("HH");


            timer1.Interval = 1000;
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTimeCount.Text += time.ToString("ss:mm:HH") + "\n";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1);
            lblSec.Text = time.ToString("ss");
            lblMin.Text = time.ToString("mm");
            lblHour.Text = time.ToString("HH");
        }
    }
}
