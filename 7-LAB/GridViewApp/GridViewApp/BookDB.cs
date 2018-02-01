using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridViewApp
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
        public ArrayList list = new ArrayList();


        public void AddBook(string title, string author, decimal price, bool paperBack)
        {
            list.Add(new Book(title, author, price,paperBack));
        }

        public void processPaperBackBooks(frmBookStore.ProcessBookDelegate processBook)
        {
            int count = 0;
            decimal totalPrice = 0;
            foreach (Book  b in list)
            {
                ++count;
                totalPrice += b.Price;
                if (b.PaperBack)
                {
                    processBook(b);
                }

                decimal average = totalPrice / count;

            }
        }
    }
}
