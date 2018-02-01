using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSqlApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            EmployeeDataContext employeeContext = new EmployeeDataContext();
            Table<Employee> employeesTable = employeeContext.Employees;
            List<Employee> employeesList = (from emp in employeesTable
                                            select emp).ToList<Employee>();


            foreach (Employee emp in employeesList)
            {
                this.listBox1.Items.Add(emp);
            }

                            


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)this.listBox1.SelectedItem;
            this.textBox1.Text = Convert.ToString(emp.Id);
            this.textBox2.Text = emp.Name;
            this.textBox3.Text = emp.City;

        }
    }
}
