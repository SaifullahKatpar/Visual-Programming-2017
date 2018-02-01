using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class Form1 : Form
    {



        bool opGiven = false;
        bool resGiven = false;
        string valChar1, valChar2;
        int val1, val2, res;
        char op;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            opGiven = false;
            this.txtCalc.Text = "";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(this.txtCalc.Text);
            this.txtCalc.Text = "+";
            op = Convert.ToChar(this.txtCalc.Text);
            opGiven = true;
        }

        private void txtFirstValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSecondValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

            val1 = Convert.ToInt32(this.txtCalc.Text);
            this.txtCalc.Text = "";
            this.txtCalc.Text = "-";
            op = Convert.ToChar(this.txtCalc.Text);
            opGiven = true;


        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(this.txtCalc.Text);
            this.txtCalc.Text = "";
            this.txtCalc.Text = "*";
            op = Convert.ToChar(this.txtCalc.Text);
            opGiven = true;
        }

        private void lblFirstValue_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

     
            if (opGiven)
            {
                this.txtCalc.Text = "7";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "8";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "8";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            val2 = Convert.ToInt32(this.txtCalc.Text);
            

            switch (op)
            {
                case '+':
                    res = val1 + val2;
                    break;
                case '-':
                    res = val1 - val2;
                    break;
                case '*':
                    res = val1 * val2;
                    break;
                case '/':
                    res = val1 / val2;
                    break;
            }

            this.txtCalc.Text = Convert.ToString(res);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "9";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "9";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "6";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "6";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "5";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "4";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "3";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "3";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "2";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "2";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "0";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "0";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (opGiven)
            {
                this.txtCalc.Text = "1";
                opGiven = false;
            }
            else
            this.txtCalc.Text += "1";

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(this.txtCalc.Text);
            this.txtCalc.Text = "";
            this.txtCalc.Text = "-";
            op = Convert.ToChar(this.txtCalc.Text);
            opGiven = true;
        }
    }
}
