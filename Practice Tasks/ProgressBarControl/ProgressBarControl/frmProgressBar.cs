using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarControl
{
    public partial class frmProgressBar : Form
    {
        public frmProgressBar()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.progressBar.Value += 10;
            if (this.progressBar.Value >= 100)
            {
                this.timer.Stop();
                MessageBox.Show("Process Completed!");
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.progressBar.Minimum = 0;
            this.progressBar.Maximum = 100;
            Application.EnableVisualStyles();
            //            this.progressBar.Style = ProgressBarStyle.Marquee;
            //            this.progressBar.MarqueeAnimationSpeed = 20;
            this.progressBar.Style = ProgressBarStyle.Blocks;
            this.timer.Interval = 1000;
            this.timer.Start();
        }
    }
}
