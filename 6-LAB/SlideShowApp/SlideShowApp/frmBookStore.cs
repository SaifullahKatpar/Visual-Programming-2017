using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlideShowApp
{
    public partial class frmBookStore : Form
    {
        BookDB database;
        public delegate void ProcessBookDelegate(Book  b);
        public frmBookStore()
        {
            InitializeComponent();
            this.cbListAs.Items.Add("Title");
            this.cbListAs.Items.Add("Author");

            database = new BookDB();
            this.addBooks(database);

            ProcessBookDelegate processor = new ProcessBookDelegate(processBooks);
            database.ProcessPaperBackBooks(processor);
        }

        public void processBooks(Book b)
        {   
            // TODO
        }

        public void addBooks(BookDB bookDB)
        {
            bookDB.addBook("The C Programming Language","Brian W. Kernighan and Dennis M. Ritchie",19.95m,true);
            bookDB.addBook("Unicode Standard 2.0", "The Unicode Consortium", 39.95m, true);
            bookDB.addBook("The MS-DOS Encyclopedia", "Ray Duncan", 129.95m,false);
            bookDB.addBook("Dogbert's Clues for the Clueless", "Scott Adams", 12.00m, true);
        }

        private void cbListAs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbListAs.SelectedItem.ToString() == "Title")
            {
                this.lbBookInfo.Items.Clear();
                foreach (Book book in database.list)
                {
                    this.lbBookInfo.Items.Add(book.Title);
                }
            }
            else if(cbListAs.SelectedItem.ToString() == "Author")
            {
                this.lbBookInfo.Items.Clear();
                foreach (Book book in database.list)
                {
                    this.lbBookInfo.Items.Add(book.Author);
                }

            }
        }
    }
}
