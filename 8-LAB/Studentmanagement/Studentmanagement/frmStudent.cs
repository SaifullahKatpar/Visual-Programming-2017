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

namespace Studentmanagement
{
    public partial class frmStudent : Form
    {
        int id;
        string firstName,lastName,city,state,country,nationality;
        string connectionString;
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            city = txtCity.Text;
            state = txtState.Text;
            country = txtCountry.Text;
            nationality = txtNationality.Text;

            var std = (Student)this.listBox1.SelectedItem;
            int selectedId;
            if (std != null)
            {
                selectedId = std.id;


                command.CommandText = String.Format("Update StudentRecord set firstName = '{0}',lastName = '{1}', city = '{2}', state = '{3}', country = '{4}', nationality = '{5}' where Id = {6};", firstName, lastName, city, state, country, nationality, selectedId);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                MessageBox.Show("No Person Chosen!");
            }

            printData();

        }

        private void txtFirstName_Click(object sender, EventArgs e)
        {
            this.txtFirstName.Text = "";
        }

        private void txtLastName_Click(object sender, EventArgs e)
        {
            this.txtLastName.Text = "";
        }



        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            initializeDatabase();
            printData();
        }


        // this method inserts new records
        private void btnAddRecord_Click(object sender, EventArgs e)
        {

            id++;
            firstName =txtFirstName.Text;
            lastName = txtLastName.Text;
            city = txtCity.Text;
            state = txtState.Text;
            country = txtCountry.Text;
            nationality = txtNationality.Text;
            try
            {
                // Assigning query to commandText property of command object
                connection.Open();
                command.CommandText = "Insert into StudentRecord(Id, firstName, lastName, city, state, country, nationality) values(" + id + ",'" + firstName + "','" + lastName + "','" + city + "','" + state + "','" + country + "','" + nationality + "' );";
                command.ExecuteNonQuery();
                connection.Close();
                printData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }// end update record


//-----------------------------------------------------

            public void printData()
        {
            this.listBox1.Items.Clear();
            try
            {
                // Assigning query to commandText property of command object
                connection.Open();
                command.CommandText = "Select * From StudentRecord;";

               reader =  command.ExecuteReader();

                while (reader.Read())
                {
                    this.listBox1.Items.Add(new Student(reader.GetInt32(0),reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6)));
                }

                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void initializeDatabase()
        {
            connectionString = ConfigurationManager.ConnectionStrings["cAString"].ConnectionString;

            //creating connection object
            connection = new SqlConnection();

            connection.ConnectionString = connectionString;

            // creating command object
            command = new SqlCommand();

            // Assigning connection object to connection property of command object
            command.Connection = connection;
            // opening connection
            //command.CommandText = "Select * from StudentRecord";
            connection.Open();
            command.CommandText = "Select Count(*) as total from StudentRecord;";
            id = (int)command.ExecuteScalar();
            connection.Close();


            // SqlDataReader datareader =  command.ExecuteReader();

            //while (datareader.Read())
            //{
            //    this.listBox1.Items.Add(new Student(datareader.GetInt32(0),datareader.GetString(1), datareader.GetString(2), datareader.GetString(3), datareader.GetString(4), datareader.GetString(5),datareader.GetString(6)));

            //}


            //datareader.Close();
            //connection.Close();

        }

        // end initializeDatabase

        private void closeConnection()
        {
            connection.Close();

        }
        private void txtCity_Click(object sender, EventArgs e)
        {
            this.txtCity.Text = "";

        }

        private void txtState_Click(object sender, EventArgs e)
        {
            this.txtState.Text = "";
        }

        private void txtCountry_Click(object sender, EventArgs e)
        {
            this.txtCountry.Text = "";
        }

        private void txtNationality_Click(object sender, EventArgs e)
        {
            this.txtNationality.Text = "";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Assigning query to commandText property of command object

                var std = (Student)this.listBox1.SelectedItem;
                if (std != null)
                {
                    int selectedId = std.id;
                    connection.Open();
                    command.CommandText = "DELETE FROM StudentRecord WHERE id = " + selectedId + ";";
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                printData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command.CommandText = "TRUNCATE TABLE StudentRecord";
                command.ExecuteNonQuery();
                connection.Close();
                printData();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNationality_TextChanged(object sender, EventArgs e)
        {

        }


    }
}



