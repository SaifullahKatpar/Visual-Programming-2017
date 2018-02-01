using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegularExpressionsApp
{
    public partial class frmRegex : Form
    {
        public frmRegex()
        {
            InitializeComponent();
            // simple example
            string output = "";
            //string[] partNumbers =
            //{
            //    "1928-673-4192","A08Z-931-468A","_A90-123-129X","12345-KKA-1230","0919-2893-1256"
            //};

            //Regex regex = new Regex(@"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[a-zA-Z0-9]$");
            //foreach (string partNumber in partNumbers)
            //{
            //    output += String.Format("{0} {1} a valid part number.\n\n", partNumber, regex.IsMatch(partNumber) ? "is" : "is not");
            //}

            // another example

            //Regex pattern = new Regex(@"[*]+");
            //Match m = pattern.Match("***");

            //while (m.Success)
            //{
            //    output += m.Value + "\n";
            //    m = m.NextMatch();
            //}
            //MessageBox.Show(output);
        }

        private void frmRegex_Load(object sender, EventArgs e)
        {
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {


            // get input text
            string inputText = this.txtBoxInput.Text.Trim();
            // get pattern to match
            string pattern = this.txtBoxPattern.Text.Trim();

            string output = "";
            Regex regex = new Regex(@""+pattern);
            output = String.Format("Matched String:\n{1}\t", inputText, regex.IsMatch(inputText) ? regex.Match(inputText).ToString() : "None");
            
            MessageBox.Show(output);
           


        }
    }
}
