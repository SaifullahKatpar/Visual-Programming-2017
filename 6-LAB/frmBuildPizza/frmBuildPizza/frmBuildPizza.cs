using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmBuildPizza
{
    public partial class frmBuildPizza : Form
    {
        string size = "";
        string topping = "Toppings: ";
        string crust = "";
        string dinning = "";

        public frmBuildPizza()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------
        private void btnBuildPizza_Click(object sender, EventArgs e)
        {
            size = "";
            topping = "Toppings: ";
            crust = "";
            dinning = "";

            if (this.rbSmall.Checked)
            {
                size = "Size:  Small";
            }
            if (this.rbMedium.Checked)
            {
                size = "Size: Medium";
            }
            if (this.rbLarge.Checked)
            {
                size = "Size: Large";

            }

            if (this.cbMushrooms.Checked)
            {
                if(!topping.Contains("Mushrooms"))
                topping += "Mushrooms, ";
            }

            if (this.cbOnions.Checked)
            {
                if (!topping.Contains("Onions"))
                    topping += "Onions, ";
            }
            if (this.cbTomatoes.Checked)
            {
                if (!topping.Contains("Tomatoes"))
                    topping += "Tomatoes, ";
            }
            if (this.cbExtraCheese.Checked)
            {
                if (!topping.Contains("Extra Cheese"))
                    topping += "Extra Cheese, ";
            }

            if (this.rbThickCrust.Checked)
            {
                crust = "Crust: Thick";
            }
            if (this.rbThinCrust.Checked)
            {
                crust = "Crust: Thin";
            }

            if (this.rbEatIn.Checked)
            {
                dinning = "Eat in";
            }
            if (this.rbTakeOut.Checked)
            {
               dinning = "Take out";
            }


            MessageBox.Show(size + "\n" + topping + "\n" + crust + "\n" + dinning);
        }

        private void frmBuildPizza_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
