using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixMultiplication
{
    public partial class frmMatrix1 : Form
    {
        public frmMatrix1()
        {
            InitializeComponent();
        }

        private void frmMatrix1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMatrix2 frm2 = new frmMatrix2();
            frm2.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[0, 0] = Convert.ToInt32( this.textBox1.Text );
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[0, 1] = Convert.ToInt32(this.textBox2.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[0, 2] = Convert.ToInt32(this.textBox3.Text);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[1,0] = Convert.ToInt32(this.textBox6.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[1, 1] = Convert.ToInt32(this.textBox5.Text);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[1, 2] = Convert.ToInt32(this.textBox4.Text);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[2, 0] = Convert.ToInt32(this.textBox9.Text);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[2, 1] = Convert.ToInt32(this.textBox8.Text);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            DataHolder.A[2, 2] = Convert.ToInt32(this.textBox7.Text);

        }
    }
}
