using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class frmStudentInfo : Form
    {

        static StudentClass[] database = new StudentClass[2];  // two students
        static string studentInfo = "";                   // 
        static int countStudents = 0;

        public frmStudentInfo()
        {
            InitializeComponent();
            this.Text = "Student Information";
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            int i = 1;
            studentInfo = "";

            studentInfo += database[0].ToString() + "\n";
            studentInfo += database[1].ToString() + "\n";




            MessageBox.Show(studentInfo);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtBoxName.Text == "" || this.txtLastName.Text == "" || this.txtAddress.Text == "" || this.txtBoxCity.Text == "" || this.txtMobileNo.Text == "")
            {
                MessageBox.Show("Fill complete information");

            }
            else
            {
                StudentClass obj = new StudentClass(this.txtBoxName.Text, this.txtLastName.Text, this.txtAddress.Text, this.txtBoxCity.Text, this.txtMobileNo.Text);
                database[countStudents] = obj;
                countStudents++;
            }


        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtBoxName.Text = "";
            this.txtLastName.Text = "";
            this.txtAddress.Text = "";
            this.txtBoxCity.Text = "";
            this.txtMobileNo.Text = "";

        }
    }
}
