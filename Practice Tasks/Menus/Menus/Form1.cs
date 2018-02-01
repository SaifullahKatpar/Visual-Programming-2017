using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        ToolStripTextBox replace;
        ToolStripTextBox replace_text;
        ToolStripTextBox find;
        public Form1()
        {
            InitializeComponent();
            // dynamically added main menu
            MenuStrip MainMenu = new MenuStrip();

            // sub menu of main menu
            ToolStripMenuItem file = new ToolStripMenuItem();
            file.Text = "File";

            ToolStripMenuItem edit = new ToolStripMenuItem();
            edit.Text = "Edit";

            ToolStripMenuItem tools = new ToolStripMenuItem();
            tools.Text = "Tools";

            //---------------------Menu of File----------------------
            ToolStripMenuItem open = new ToolStripMenuItem();
            open.Text = "Open";
            open.Click += new EventHandler(open_handler);

            ToolStripMenuItem New = new ToolStripMenuItem();
            New.Text = "New";

            ToolStripMenuItem save = new ToolStripMenuItem();
            save.Text = "Save";


            file.DropDownItems.Add(open);
            file.DropDownItems.Add(New);
            file.DropDownItems.Add(save);
            //---------------------Menu of Edit----------------------
            ToolStripMenuItem bullets = new ToolStripMenuItem();
            bullets.Text = "Bullets";
            bullets.ShortcutKeys = Keys.Control | Keys.B;

            bullets.Click += new EventHandler(bullets_Click_handler);

            replace = new ToolStripTextBox();
            replace.Text = "Enter word to replace";

            replace_text = new ToolStripTextBox();
            replace_text.Text = "Replace Text";

            find = new ToolStripTextBox();
            find.Text = "Enter word to find";

                        //----------- text box replace handler
                        replace.Click += new EventHandler(replace_Click_handler);
                        replace_text.Click += new EventHandler(replace_text_Click_handler);

            edit.DropDownItems.Add(bullets);
            edit.DropDownItems.Add(replace);
            edit.DropDownItems.Add(find);
            //---------------------Menu of Tools----------------------



            // -------- Adding to form---------------------0
            MainMenu.Items.Add(file);
            MainMenu.Items.Add(edit);
            MainMenu.Dock = DockStyle.Top;
            this.Controls.Add(MainMenu);

        }


        // -----------------------  event handler of controls in the menu--------------------
        public void open_handler(object sender, EventArgs e)
        {
            MessageBox.Show("Opened!");
        }

        public void new_handler(object sender, EventArgs e)
        {
            MessageBox.Show("New File!");
        }

        public void save_handler(object sender, EventArgs e)
        {
            MessageBox.Show("Save!");
        }

        public void replace_handler(object sender, EventArgs e)
        {
            MessageBox.Show("Replaced!");
        }

        public void replace_Click_handler(object sender, EventArgs e)
        {
            this.replace.SelectAll();
        }

        public void bullets_Click_handler(object sender, EventArgs e)
        {
            if(this.richTextBox1.SelectionBullet)
                this.richTextBox1.SelectionBullet = false;
            else
                this.richTextBox1.SelectionBullet = true;
        }

        public void replace_text_Click_handler(object sender, EventArgs e)
        {
            this.replace_text.SelectAll();
        }
  
        public void insertImage_handler(object sender, EventArgs e)
        {
            MessageBox.Show("Iamge inserted!");
        }





        //----------------------------------------------------------------
        // Context Menu added to the form
        private void Form1_Load(object sender, EventArgs e)
        {
            ContextMenuStrip cms = new ContextMenuStrip();
            this.ContextMenuStrip = cms;
            ToolStripMenuItem exit = new ToolStripMenuItem();
            exit.Text = "E&xit";
            exit.ShowShortcutKeys = true;
            exit.ShortcutKeys = Keys.Alt | Keys.E;
            exit.Click += new EventHandler(exit_Click);
            cms.Items.Add(exit);


        }

        // handler of context menu of the form
        public void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
