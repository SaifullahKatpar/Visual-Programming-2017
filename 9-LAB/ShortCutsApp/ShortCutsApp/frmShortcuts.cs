using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShortCutsApp
{
    public partial class frmShortcuts : Form
    {

        void click_notepad_handler(Object o, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");

        }
        void click_paint_handler(Object o, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");

        }
        void click_powerpoint_handler(Object o, EventArgs e)
        {
            System.Diagnostics.Process.Start("powerpnt.exe");

        }


        public frmShortcuts()
        {
            InitializeComponent();
            Button btnNotePad = new Button();
            btnNotePad.Text = "Notepad";
            btnNotePad.Height = 50;
            btnNotePad.Width = 100;
            btnNotePad.Top = 50;
            btnNotePad.Left = 50;

            Button btnPaint = new Button();
            btnPaint.Text = "Paint";
            btnPaint.Height = 50;
            btnPaint.Width = 100;
            btnPaint.Top = 150;
            btnPaint.Left = 50;

            Button btnPowerPoint = new Button();
            btnPowerPoint.Text = "Power Point";
            btnPowerPoint.Height = 50;
            btnPowerPoint.Width = 100;
            btnPowerPoint.Top = 250;
            btnPowerPoint.Left = 50;


            this.Controls.Add(btnNotePad);
            this.Controls.Add(btnPaint);
            this.Controls.Add(btnPowerPoint);

            btnNotePad.Click += new EventHandler(click_notepad_handler);
            btnPaint.Click += new EventHandler(click_paint_handler);
            btnPaint.Click += new EventHandler(click_powerpoint_handler);
           

        }
    }
}
