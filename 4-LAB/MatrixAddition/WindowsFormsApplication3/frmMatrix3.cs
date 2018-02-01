using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class frmMatrix3 : Form
    {
        public frmMatrix3()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMatrix2 frm3 = new frmMatrix2();
            frm3.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[0, 1] = Convert.ToInt32(this.textBox3.Text);

        }

        private void frmMatrix3_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[1, 0] = Convert.ToInt32(this.textBox5.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[1, 0] = Convert.ToInt32(this.textBox2.Text);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[0,0] = Convert.ToInt32(this.textBox1.Text); 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[1, 2] = Convert.ToInt32(this.textBox4.Text);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[1, 0] = Convert.ToInt32(this.textBox6.Text);

        }
    }
}
