using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        //download button
        private void ro_Click(object sender, EventArgs e)
        {
            // set ,min
            this.progressBar1.Minimum = 1;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 1;
            for (int i = 1; i < 50; i++)
            {
                this.progressBar1.Value++;
            }

        }
    }
}
