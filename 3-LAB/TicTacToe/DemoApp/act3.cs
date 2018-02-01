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
    public partial class act3 : Form
    {



        string valChar1 = "", valChar2 = "";
        public act3()
        {
            InitializeComponent();
        }

        private void act3_Load(object sender, EventArgs e)
        {

        }

        private void txtCalc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            this.txtCalc.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "9";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "6";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "4";

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.txtCalc.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "2";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "1";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "0";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            this.txtCalc.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            char[] text = this.txtCalc.Text.ToCharArray();


            bool opGiven = false;
            char op = ' ';


            foreach (char x in text)
            {

                if (x == '+' || x == '-' || x == '*' || x == '/')
                {
                    op = x;
                    opGiven = true;
                    continue;
                }
                if (opGiven)
                    valChar2 += x;
                else
                    valChar1 += x;
            }


            int val1 = Convert.ToInt32(valChar1);
            int val2 = Convert.ToInt32(valChar2);
            int res = 0;
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




        private void btnDivide_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "/";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            this.txtCalc.Text += "*";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "-";

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtCalc.Text += "+";
        }
    }
}
