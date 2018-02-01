using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor
{
    public partial class Form1 : Form
    {
        string path = "E:\\";
        public Form1()
        {
            InitializeComponent();
            this.openFileDialog1.InitialDirectory = path;
            this.ContextMenuStrip = this.contextMenuStrip1;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.richTextBox1.Text = File.ReadAllText(path+openFileDialog1.SafeFileName);

             }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.AppendAllText(this.saveFileDialog1.FileName,this.richTextBox1.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void unoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void pastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.colorDialog1.ShowDialog()==DialogResult.OK)
            {
                this.richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fontDialog1.ShowDialog()==DialogResult.OK)

            {
                this.richTextBox1.Font = this.fontDialog1.Font;
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
