using Didacticiel.db;
using System;

namespace Didacticiel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("**** Bien démarrer avec EF Core ****");
            Console.WriteLine("************************************");

            DatabaseTests();
        }

        private static void DatabaseTests()
        {
            var dao1 = new Dao<Blog>("Blog");
            var dao2 = new Dao<Post>("Post");

            dao1.add(new Blog("EF Core with Reflection.fr"));
            dao1.add(new Blog("EF Core with Reflection.com"));

            var post1 = new Post();
            post1.Title = "Post EF Core Demo!";
            post1.Content = "lorem ipsum..";
            post1.BlogId = 1;

            dao2.add(post1);

            
        }
    }
}
