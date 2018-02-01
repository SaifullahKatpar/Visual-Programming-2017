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
    public partial class BillCalculation : Form
    {

        static float units = 0;
        static float bill = 0;
        static int[] price = { 2, 3, 4, 7 };

        public BillCalculation()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Name = "lblUnits";
        }

        private void BillCalculation_Load(object sender, EventArgs e)
        {

        }


        private void lblBill_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           int units = Convert.ToInt32(this.textBox1.Text);
            if (units > 400)
            {
                calculate(units - 400);
                units = 400;
            }


            //    System.out.println("before second call [units,bill]: "+ units + " " + bill );
            calculate(units, 300);
            this.textBox2.Text= Convert.ToString(bill);

        }


        private static void calculate(int units, int fatcor)
        {
            float cent = units / 100;
            float left = units - ((int)cent) * 100;
            int i=0;
            for (i = 0; i < (int)cent; i++)
            {

                bill += 100 * price[i];

            }
            bill += left * price[i-1];

        }


        private static void calculate(int extra)
        {
            int price = 9;
            float cent = extra / 100;
            float left = extra - ((int)cent) * 100;
            for (int i = 0; i < (int)cent; i++)
            {
                bill += 100 * price;
                price += 2;
            }

            bill += left * price;



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
