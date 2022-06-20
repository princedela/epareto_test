using System;
using DemoCore.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace DemoCore.Data.DBContext
{

        public class AppDBContext : DbContext
        {
            public AppDBContext(DbContextOptions<AppDBContext> options)
                : base(options)
            {
            }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
