using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Database
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            getUserData();
        }

        public void getUserData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;
            connection = new SqlConnection(connectionString);
            // connection.ConnectionString = @" Data Source = (localdb)\MSSQLLocalDB;
            //initial catalog = PracticeDatabse;
            //integrated security = SSPI";

            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            string fname = "username";
            string lname = "password";

            //            command.CommandText = "Select * from Employee";
            command.CommandText = "Insert into Employee(Fname,Lname) values('" + fname + "', '" + lname + "' );";


            connection.Open();

            // read
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    this.listEmployees.Items.Add(new Employee(reader.GetInt32(0),reader.GetString(1), reader.GetString(2)));
            //}
            //reader.Close();

            // insert
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
