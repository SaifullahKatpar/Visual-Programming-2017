using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EditorApp
{
    public partial class frmEditor : Form
    {
        string fileName = "";
        string alltext = "";
        public frmEditor()
        {
            InitializeComponent();
            this.richTextBox1.Font = new Font("calibri",12);
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create new text document
            // prompt user to save before creating new file
            this.richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // open a text file
            OpenFileDialog oFD = new OpenFileDialog();
            oFD.InitialDirectory = @"C:\users\saifullah\Desktop";
            oFD.Multiselect = false;
            oFD.ShowHelp = false;
            try
            {
                if (oFD.ShowDialog() == DialogResult.OK)
                {
                    fileName = oFD.FileName;
                    this.richTextBox1.LoadFile(fileName,RichTextBoxStreamType.RichText);
                }

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // save a file as .rtf
            SaveFileDialog sFD = new SaveFileDialog();
            sFD.InitialDirectory = @"C:\users\saifullah\Desktop";
            sFD.ShowHelp = false;
            sFD.AddExtension = true;
          
            try
            {
                if (sFD.ShowDialog() == DialogResult.OK)
                {
                    this.richTextBox1.SaveFile(fileName, RichTextBoxStreamType.RichText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // save work before exit
            Application.Exit();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fD = new FontDialog();
            fD.ShowHelp = false;
            if (fD.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.SelectionFont = fD.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cD = new ColorDialog();
            cD.ShowHelp = false;
            if (cD.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.SelectionColor = cD.Color;
            }

        }
    }
}
