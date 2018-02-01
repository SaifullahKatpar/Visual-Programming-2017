using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                // create and save a new Blog
                Console.WriteLine("Enter a name for new Blog: ");
                var name = Console.ReadLine();
                int id = (from b in db.Blogs
                          select b).Count() + 1;


                var blog = new Blog { Name = name,Id = id};
                db.Blogs.Add(blog);
                db.SaveChanges();

                // Display all Blogs from the database

                var query = from b in db.Blogs
                            orderby b.Name
                            select b;
                Console.WriteLine("All Blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit....");
                Console.ReadKey();

            }
        }
    }
}
