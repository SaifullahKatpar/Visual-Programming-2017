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

namespace DatabaseApplication
{
    public partial class frmConnectedAccess : Form
    {

        int id;
        string username;
        string password;
        public frmConnectedAccess()
        {
            InitializeComponent();
        }



        private void getUserData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;

            //creating connection object
            SqlConnection connection = new SqlConnection();

            connection.ConnectionString = connectionString;

            // creating command object
            SqlCommand command = new SqlCommand();

            // Assigning connection object to connection property of command object
            command.Connection = connection;

            // Assigning query to commandText property of command object
            command.CommandText = "Select * from Info";

            // opening connection
            connection.Open();


            // executing query using command object and assigning it to datareader object
            SqlDataReader datareader = command.ExecuteReader();


            // reading records one by one by using read method of datareader object 
            while (datareader.Read())
            {
                // assigning id col by using data reader
                id = (int) datareader["Id"];

                // assigning name col by using data reader
                username =(string) datareader["username"];

                // password from password col
                password = (string)datareader["password"];

                this.lblInfo.Text += id + "\n"
                    + username + "\n" + password + "\n\n";
            }
            // closing datareader object 
            datareader.Close();
            // closing connection object
            connection.Close();
        }

        private void frmConnectedAccess_Load(object sender, EventArgs e)
        {
            getUserData();
        }


    }
}
