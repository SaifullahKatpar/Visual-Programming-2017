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

namespace disconnectedAccess
{
    public partial class Form1 : Form
    {
        DataSet students;
        string tableName = "Student";
        SqlDataAdapter sda;
        public Form1()
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
            connection.Close();
            this.dataGridView1.DataSource = students.Tables[0];
        }
    }
}
