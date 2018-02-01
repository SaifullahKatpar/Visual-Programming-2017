using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridViewApp
{
    public partial class frmGridView : Form
    {

        Person[] persons;

        public frmGridView()
        {
            InitializeComponent();
            persons = new Person[5];
            // populate
            Person p = new Person();
            p.FirstName = "Alan Mathison";
            p.LastName = "Turing";
            p.City = "London";
            persons[0] = p;

            p = new Person();
            p.FirstName = "Timothy John";
            p.LastName = "Berners-Lee";
            p.City = "London";
            persons[1] = p;


            p = new Person();
            p.FirstName = "Dennis MacAlistair";
            p.LastName = "Ritchie";
            p.City = "New York";
            persons[2] = p;

            p = new Person();
            p.FirstName = "Donald Ervin";
            p.LastName = "Knuth";
            p.City = "Wisconsin";
            persons[3] = p;


            p = new Person();
            p.FirstName = "Richard Ernest";
            p.LastName = "Bellman";
            p.City = "California";
            persons[4] = p;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            this.PersonTable.DataSource = persons;
        }
    }
}
