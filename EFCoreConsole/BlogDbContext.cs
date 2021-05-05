using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreConsole
{
    /**
     * Microsoft.EntityFrameworkCore
     * Microsoft.EntityFrameworkCore.SqlServer
     * Microsoft.EntityFrameworkCore.Tools
     * 
     * Add-Migration InitialCreate
     * Update-Database
     */
    class BlogDbContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyBlog;Integrated Security=True");
     

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseLazyLoadingProxies()
        //        .UseSqlServer(myConnectionString);
    }

    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }

   
        //public List<Post> Posts { get; set; }

        public Blog(int blogId, string url, int rating)
        {
            BlogId = blogId;
            Url = url ?? throw new ArgumentNullException(nameof(url));
            Rating = rating;
        }

        public Blog(string url, int rating)
        {
            Url = url ?? throw new ArgumentNullException(nameof(url));
            Rating = rating;
        }

        public override string ToString() => $"[{BlogId}] {Url} : {Rating} - {Posts}";

        /**
         * Lazy Loading
         */
        private ICollection<Post> _posts;
        private Blog(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }

        private ILazyLoader LazyLoader { get; set; }
        public ICollection<Post> Posts
        {
            get => LazyLoader.Load(this, ref _posts);
            set => _posts = value;
        }
    }

    public class Post
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //public int BlogId { get; set; }
        //public Blog Blog { get; set; }
        //public Post()
        //{
        //}

        public override string ToString() => $"[{PostId}] {Title} : {Blog}!";

        /**
         * Lazy Loading
         */
        private Blog _blog;
        private Post(ILazyLoader lazyLoader)
        {
            LazyLoader = lazyLoader;
        }
        private ILazyLoader LazyLoader { get; set; }
        public Blog Blog
        {
            get => LazyLoader.Load(this, ref _blog);
            set => _blog = value;
        }
    }
}
