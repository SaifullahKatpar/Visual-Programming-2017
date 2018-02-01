using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqExamples
{
    public partial class frmLinq : Form
    {

        List<Employee> employees;

        Employee emp;
        public frmLinq()
        {
            InitializeComponent();
            filter.Items.Add("All Employees");
            filter.Items.Add("First Name");
            filter.Items.Add("Last Name");
            filter.Items.Add("City");

            employees = new List<Employee>();
            emp = new Employee("john", "gage", "london");
            employees.Add(emp);

            emp = new Employee("jane", "smith", "chicago");
            employees.Add(emp);

            emp = new Employee("jane", "brown", "boston");
            employees.Add(emp);

            emp = new Employee("jane", "jones", "seatle");
            employees.Add(emp);

            emp = new Employee("john", "brown", "london");
            employees.Add(emp);

        }

        private void frmLinq_Load(object sender, EventArgs e)
        {

        }

//------------------------------------------
        private IEnumerable<Employee> getValuesAccordingToName(string name)
        {
            IEnumerable<Employee> records = from emp in this.employees
                                            where emp.firstName == name
                                            select emp;

            return records;
        }


//------------------------------------------
        private IEnumerable<Employee> getValuesAccordingToLastName(string lastName)
        {
            IEnumerable<Employee> records = from emp in this.employees
                                            where emp.lastName == lastName
                                            select emp;
            return records;
        }


//--------------------------------------
        private IEnumerable<Employee> getValuesAccordingToCity(string city)
        {
            IEnumerable<Employee> records = from emp in this.employees
                                            where emp.city == city
                                            select emp;

            return records;
        }
        //---------------------------------------
        private IEnumerable<Employee> getAllValues()
        {
            IEnumerable<Employee> records = from emp in this.employees
                                            select emp;

            return records;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
       }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            search(this.filter.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            search(this.filter.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            search(this.filter.Text);

        }



        public void search(string key)
        {

            IEnumerable<Employee> records = null;
            switch (key)
            {
                case "All Employees":
                    records = getAllValues();
                    break;
                case "First Name":
                    records = getValuesAccordingToName(this.txtName.Text);
                    break;
                case "last Name":
                    records = getValuesAccordingToLastName(this.txtLname.Text);
                    break;
                case "City":
                    records = getValuesAccordingToCity(this.txtCity.Text);
                    break;
                default:
                    break;
            }
            foreach (Employee record in records)
            {
                this.listBox.Items.Add(record);
            }

        }
        private void txtName_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
        }

        private void txtLname_Click(object sender, EventArgs e)
        {
            this.txtLname.Text = "";
        }

        private void txtCity_Click(object sender, EventArgs e)
        {
            this.txtCity.Text = "";
        }

        private void filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            IEnumerable<Employee> records = null;
            if (this.filter.Text == "All Employees")
            {
                this.txtLname.Enabled = false;
                this.button1.Enabled = false;
                this.txtCity.Enabled = false;
                this.button2.Enabled = false;
                this.txtName.Enabled = false;
                this.button3.Enabled = false;
                records = getAllValues();
                foreach (Employee record in records)
                {
                    this.listBox.Items.Add(record);
                }
            }
            else if(this.filter.Text == "First Name")
            {
                this.txtLname.Enabled = false;
                this.button2.Enabled = false;
                this.txtCity.Enabled = false;
                this.button3.Enabled = false;
                this.txtName.Enabled = true;
                this.button1.Enabled = true;
            }
            else if (this.filter.Text == "Last name")
            {
                this.button1.Enabled = false;
                this.button3.Enabled = false;

                this.txtCity.Enabled = false;
                this.txtName.Enabled = false;

                this.button2.Enabled = true;
                this.txtLname.Enabled = true;
            }
            else if (this.filter.Text == "City")
            {
                this.button1.Enabled = false;
                this.button2.Enabled = false;
                this.txtName.Enabled = false;
                this.txtLname.Enabled = false;

                this.button3.Enabled = true;
                this.txtCity.Enabled = true;
            }

        }
    }
}
