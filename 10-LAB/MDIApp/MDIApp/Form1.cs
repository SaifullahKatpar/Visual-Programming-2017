using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIApp
{
    public partial class Form1 : Form
    {
        Form2 frm2 = new Form2();
        Form3 frm3 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void showForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void hideFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2.Hide();

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3.Show();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3.Hide();
        }
    }
}
