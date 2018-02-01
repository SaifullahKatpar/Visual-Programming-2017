using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblSeason_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int month = Convert.ToInt32(this.txtMonth.Text);

            switch (month)
            {
                case 12:
                case 1:
               case 2:
                    this.txtMonth.Text = "Winter";
                    break;
                case 3:
                case 4:
               case 5:
                    this.txtMonth.Text = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    this.txtMonth.Text = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    this.txtMonth.Text = "Autumn";
                    break;
                default:
                    this.txtMonth.Text = "Invalid Number";
                    break;
            }

        }

    }
}
