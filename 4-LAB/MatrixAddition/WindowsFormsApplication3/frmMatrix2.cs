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
    public partial class frmMatrix2 : Form
    {
        public frmMatrix2()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            add();
            this.Hide();
            frmMatrix1 frm1 = new frmMatrix1();
            frm1.SetLabel1();           
            frm1.ShowDialog();
        }

        private void frmMatrix2_Load(object sender, EventArgs e)
        {

        }


        public void add()
        {
            DataHolder.sum = "\n\n\t\t";
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    DataHolder.C[i, j] = DataHolder.A[i, j] + DataHolder.B[i, j];

                    DataHolder.sum += DataHolder.C[i,j] + " "; 
                }
                DataHolder.sum +="\n";
            }

          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[0, 0] = Convert.ToInt32(this.textBox1.Text);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[0, 1] = Convert.ToInt32(this.textBox3.Text);

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[0, 2] = Convert.ToInt32(this.textBox6.Text);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[0, 0] = Convert.ToInt32(this.textBox2.Text);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[1, 1] = Convert.ToInt32(this.textBox5.Text);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            DataHolder.B[1, 2] = Convert.ToInt32(this.textBox4.Text);

        }
    }
}
