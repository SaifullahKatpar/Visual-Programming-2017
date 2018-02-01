using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Processes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Process[] processlist = Process.GetProcesses();
            foreach (Process theProcess in processlist)
            {
                this.listBox1.Items.Add(theProcess.ProcessName);
            }
            

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
