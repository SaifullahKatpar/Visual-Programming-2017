using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        Graphics drawArea;
        int x1, x2, y1, y2;
        public Form1()
        {
            InitializeComponent();
            drawArea = drawingArea.CreateGraphics();

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            x1 = Convert.ToInt32(this.tbX1.Text);
            y1 = Convert.ToInt32(this.tbY1.Text);
            x2 = Convert.ToInt32(this.tbX2.Text);
            y2 = Convert.ToInt32(this.tbY2.Text);

            Pen blackPen = new Pen(Color.Black);
            drawArea.DrawLine(blackPen, x1,y1,x2,y2);

            //SolidBrush blueBrush = new SolidBrush(Color.Blue);
            //drawArea.FillEllipse(blueBrush,50,50,200,200);
        }
    }
}
