using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dcAccessApp
{
    public partial class frmdcAccess : Form
    {
        DataSet students;
        string tableName = "Student";
        SqlDataAdapter sda;
        public frmdcAccess()
        {
            InitializeComponent();
            //Load data from database
            initializaData();
        }

        public void initializaData()
        {
            // connection
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            // command sql
            SqlCommand command = new SqlCommand("SELECT * FROM " + tableName, connection);


            // data adapter 
            sda = new SqlDataAdapter(command);
            students = new DataSet();
            sda.Fill(students); // filling database usong data adapter


            
            printData();
        }


        public void printData()
        {
            this.listBox1.Items.Clear();
            DataTableReader dtr = new DataTableReader(students.Tables[0]);

            while (dtr.Read())
            {
                this.listBox1.Items.Add(new Student(dtr.GetInt32(0), dtr.GetString(1), dtr.GetString(2), dtr.GetString(3)));
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtId.Enabled = true;
            Student std = (Student)this.listBox1.SelectedItem;

            this.txtId.Text = "" + std.id;
            this.txtName.Text = std.name;
            this.txtCity.Text = std.city;
            this.txtState.Text = std.state;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TextBox.ControlCollection fields = this.panel1.Controls;
            foreach (TextBox textBox in fields)
            {
                textBox.Text = "";
            }
            this.txtId.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox.ControlCollection fields = this.panel1.Controls;
            if ( fields[1].Text == String.Empty || fields[2].Text == String.Empty || fields[3].Text == String.Empty)
            {
                MessageBox.Show("Fill the missing Fields");

            }
            else
            {
                DataRow dr = students.Tables[0].NewRow();
                dr["Id"] = students.Tables[0].Rows.Count + 1;
                dr["name"] = this.txtName.Text;
                dr["city"] = this.txtCity.Text;
                dr["state"] = this.txtState.Text;
                students.Tables[0].Rows.Add(dr);
            }
            printData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            sda.Update(students.Tables[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student std = (Student)this.listBox1.SelectedItem;
            this.txtId.Enabled = false;
            students.Tables[0].Rows[std.id-1][1] = this.txtName.Text;
            students.Tables[0].Rows[std.id-1][2] = this.txtCity.Text;
            students.Tables[0].Rows[std.id-1][3] = this.txtState.Text;
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            sda.Update(students.Tables[0]);
            printData();
        }
    }
}
