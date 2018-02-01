using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShowApp
{
    public partial class frmGridView : Form
    {
        Person[] persons;
        public frmGridView()
        {
            InitializeComponent();
            persons = new Person[5];

            Person p;
            // populate
            p = new Person();
            p.FirstName = "Saifullah";
            p.LastName = "Katpar";
            p.City = "Larkana";
            persons[0] = p;

            p = new Person();
            p.FirstName = "Sair Ali";
            p.LastName = "Aghani";
            p.City = "Larkana";
            persons[1] = p;

            p = new Person();
            p.FirstName = "Liaquat Ali";
            p.LastName = "Malik";
            p.City = "Ghotki";
            persons[2] = p;

            p = new Person();
            p.FirstName = "Sagar Kumar";
            p.LastName = "Bhatia";
            p.City = "Khairpur";
            persons[3] = p;

            p = new Person();
            p.FirstName = "Touqeer Abbas";
            p.LastName = "Shah";
            p.City = "Sukkur";
            persons[4] = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PersonGridView.DataSource = persons;
        }
    }
}
