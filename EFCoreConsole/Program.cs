using Region20Database.dao;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************************");
            Console.WriteLine("EF Core DbConttext + Reflection!");
            Console.WriteLine("********************************");
            //using (var db = new BlogDbContext())
            //{
            //    var blogs = db.Blogs
            //        .Where(b => b.Rating > 3)
            //        .OrderBy(b => b.Url)
            //        .ToList();
            //}
            var dao = new Dao<Blog>("Blog");
            var dao2 = new Dao<Post>("Post");

            //var blog1 = dao.find(1);
            //var post1 = new Post();
            //post1.Title = "Post EF Core Demo!";
            //post1.Content = "lorem ipsum..";
            //post1.Blog = blog1;

            //dao2.add(post1);

            //dao.add(new Blog("EF Core with Reflection.fr", 5));
            //dao.add(new Blog("EF Core with Reflection.com", 5));

            //for (int i = 0; i <=10; i++)
            //    dao.delete(i);

            //var x = dao.find(11);
            //x.Url = "working!.com";
            //dao.update(x);

            Console.WriteLine("Blogs :");
            List<Blog> items = dao.list();
            foreach (var item in items)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine("Posts :");
            List<Post> items2 = dao2.list();
            foreach (var item in items2)
                Console.WriteLine(item);

            //Console.WriteLine();
            //Console.WriteLine($"dao.find(15): {dao.find(15)}");
            //Console.WriteLine($"dao.find(100): {dao.find(100)}");
            Console.WriteLine("********************************");
        }
    }
}
