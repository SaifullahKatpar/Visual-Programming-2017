using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet dataset = new DataSet();
            DataTable tableUsername = new DataTable();
            tableUsername.TableName = "Username";

            DataColumn tableUsernameFirstCol = new DataColumn();
            tableUsernameFirstCol.ColumnName = "Id";
            tableUsernameFirstCol.DataType = Type.GetType("System.Int32");

            DataColumn tableUsernameSecondCol = new DataColumn();
            tableUsernameSecondCol.ColumnName = "username";
            tableUsernameSecondCol.DataType = Type.GetType("System.String");

            DataColumn tableUsernameThirdCol = new DataColumn();
            tableUsernameThirdCol.ColumnName = "passwrod";
            tableUsernameThirdCol.DataType = Type.GetType("System.String");


            tableUsername.Columns.Add(tableUsernameFirstCol);
            tableUsername.Columns.Add(tableUsernameSecondCol);
            tableUsername.Columns.Add(tableUsernameThirdCol);

            DataRow dr1 = tableUsername.NewRow();

            dr1[0] = 1;
            dr1[1] = "new user";
            dr1[2] = "password";


            tableUsername.Rows.Add(dr1);
            dataset.Tables.Add(tableUsername);
            this.dataGridView1.DataSource = dataset.Tables["Username"];

        }

    }
}
