using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuAdvanced
{
    public partial class frmMenuAdvanced : Form
    {

        ToolStripMenuItem ShowImage;
        ContextMenuStrip buttonContextMenu;
        Image i = Image.FromFile(@"..\..\MenuAdvanced\MenuAdvanced\click.png");


        public frmMenuAdvanced()
        {
            InitializeComponent();
        }

        private void frmMenuAdvanced_Load(object sender, EventArgs e)
        {

            buttonContextMenu = new ContextMenuStrip();
            ShowImage = new ToolStripMenuItem();


            buttonContextMenu.Items.Add(ShowImage);
            ShowImage.CheckOnClick = true;
            ShowImage.CheckedChanged += new EventHandler(showImage_CheckedChanged);

            



        }


        public void showImage_CheckedChanged(Object o, EventArgs e)
        {
            if (ShowImage.Checked)
                this.button1.Image = i;
            else
                this.button1.Image = null;


        }

    }
}
