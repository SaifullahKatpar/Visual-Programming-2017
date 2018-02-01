using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmDynamicArray
{
    public partial class frmDynamicArray : Form
    {
        StudentClass[] record = new StudentClass[2];
        int i = 0;
        String name = "";
        public frmDynamicArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass std = null;
            if ( !(name == "Enter Student Name") && !(name == ""))
            {
                MessageBox.Show("Record Added!");
                this.lblStudents.Text += name + "\n";
                std = new StudentClass(name);
                if(i>= record.Length)
                {
                    StudentClass[] temp = this.record;
                    StudentClass[] record = new StudentClass[2*this.record.Length];
                    for (int i = 0; i < temp.Length; i++)
                    {
                        record[i] = temp[i];
                    }
//                    MessageBox.Show(""+record.Length);
                }
                record[i++] = std;
            }

        }

        private void frmDynamicArray_Load(object sender, EventArgs e)
        {

        }

        private void txtStudents_TextChanged(object sender, EventArgs e)
        {

        }

        private void leftTextBox(object sender, EventArgs e)
        {
            name = this.txtStudents.Text;
            this.txtStudents.Text = "Enter Student Name";
        }

        private void enterdTextBox(object sender, EventArgs e)
        {
            this.txtStudents.Text = "";

        }
    }
}
