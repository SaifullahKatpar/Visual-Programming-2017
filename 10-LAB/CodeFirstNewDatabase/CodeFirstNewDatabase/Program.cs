using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CodeFirstNewDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new BloggingContext())
            {
                Console.WriteLine("Enter a name of Blog");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();


                var query = from b in db.Blogs
                            orderby b.Name
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.BlogId +"----" + item.Name);
                }
            }
        }
    }


    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
    }


    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string content { get; set; }
        public int BlogId { get; set; }
    }

    public class BloggingContext: DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }

}
