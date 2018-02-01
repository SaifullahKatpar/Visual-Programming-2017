using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlideShowApp
{
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public bool PaperBack;

        public Book(string title, string author, decimal price, bool paperBack)
        {
            Title = title;
            Author = author;
            Price = price;
            PaperBack = paperBack;
        }
    }
    public class BookDB
    {
        // List of all books in the database
        public ArrayList list = new ArrayList();
        public void addBook(string title, string author, decimal price, bool paperBack)
        {
            list.Add(new Book(title,author,price,paperBack));

        }


        // Call a passed-in delegate on each paperback bookto process it
        public void ProcessPaperBackBooks(frmBookStore.ProcessBookDelegate processBook)
        {
            decimal totalPrice = 0;
            int numberOfBooks = 0;
            foreach (Book b in list)
            {
                totalPrice += b.Price;
                numberOfBooks++;
                if (b.PaperBack) //calling the delegate
                    processBook(b);
            }

            decimal average = totalPrice / numberOfBooks;

        }
    }
}
