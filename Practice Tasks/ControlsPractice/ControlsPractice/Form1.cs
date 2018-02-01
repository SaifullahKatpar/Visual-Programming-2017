using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            this.btnClick.Text = "Welcome!";
        }

        private void btnClick1_Click(object sender, EventArgs e)
        {
            this.btnClick2.Text= "Welcome!";
            this.btnClick2.TabStop = false;

        }

        private void btnClick2_Click(object sender, EventArgs e)
        {
            this.btnClick2.Text = "Welcome!";
        }
    }
}
