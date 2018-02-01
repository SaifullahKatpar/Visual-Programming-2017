using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashScreen
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.progressBar1.Minimum = 0;
            this.progressBar1.Maximum= 110;
            this.progressBar1.Value = 0;


        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

            WaitTimer.Start();
            WaitTimer.Interval = 1000;
 

        }
        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 10;
            if (this.progressBar1.Value > 100)
            {
                WaitTimer.Stop();
                this.Hide();
                SwitchForm newForm = new SwitchForm();
                newForm.Show();
            }

        }
    }
}
