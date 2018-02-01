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
    public partial class frmMatrix3 : Form
    {
        public frmMatrix3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void SetLabel1()
        {
            this.label1.Text = DataHolder.product;
        }

    }
}
