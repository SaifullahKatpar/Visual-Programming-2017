using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridViewApp
{
    public partial class frmBookStore : Form
    {
        public delegate void ProcessBookDelegate(GridViewApp.Book b);
        BookDB database;
        public void processBook(Book b)
        {
            //TODO
        }
        public frmBookStore()
        {
            InitializeComponent();
            String[] menu = new String[] { "Title", "Author"};
            this.comboBox.Items.AddRange(menu);
        }

        private void frmBooksStore_Load(object sender, EventArgs e)
        {


            database = new BookDB();
            this.AddBooks(database);
            ProcessBookDelegate processor = new ProcessBookDelegate(processBook);
            database.processPaperBackBooks(processor);            
        }

        public void AddBooks(BookDB bookDb)
        {
            bookDb.AddBook("A Beautiful Mind","John Forbes Nash",8.63m,true);
            bookDb.AddBook("The Art of Programming","Donald Knuth",43.6m,true);
            bookDb.AddBook("Pride and Prejudice","Jane Austen",10.0m,false);
            bookDb.AddBook("Alice's Adventures in Wonderland","Charles Lutwidge",20.5m,true);

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBox.Items.Clear();
            if(this.comboBox.SelectedItem.ToString() == "Title")
            {
                foreach (Book b in database.list)
                {
                    this.listBox.Items.Add(b.Title);
                }
            }
            else if (this.comboBox.SelectedItem.ToString() == "Author")
            {
                foreach (Book b in database.list)
                {
                    this.listBox.Items.Add(b.Author);
                }
            }
        }
    }
}
