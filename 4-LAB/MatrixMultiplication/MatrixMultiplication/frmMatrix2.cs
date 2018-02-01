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
    public partial class frmMatrix2 : Form
    {

        int length = 3;
        public frmMatrix2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[0, 0] = Convert.ToInt32(this.textBox1.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[0, 1] = Convert.ToInt32(this.textBox2.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[0, 2] = Convert.ToInt32(this.textBox3.Text);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[1, 0] = Convert.ToInt32(this.textBox6.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[1, 1] = Convert.ToInt32(this.textBox5.Text);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[1, 2] = Convert.ToInt32(this.textBox4.Text);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[2, 0] = Convert.ToInt32(this.textBox9.Text);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[2, 1] = Convert.ToInt32(this.textBox8.Text);

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[2, 2] = Convert.ToInt32(this.textBox7.Text);

        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {

            multiply();
            this.Hide();
            frmMatrix3 frm3 = new frmMatrix3();
            frm3.SetLabel1();
            frm3.ShowDialog();

        }




        public void multiply()
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    for (int k = 0; k < length; k++)
                    {
                        DataHolder.C[i, j] = DataHolder.C[i, j] + DataHolder.A[i, k] * DataHolder.B[k, j];

                    }
                    DataHolder.product += DataHolder.C[i, j] + "      ";

                }
                DataHolder.product += "\n";
            }

        } // multiply() ends 

        //----------

    }
}
