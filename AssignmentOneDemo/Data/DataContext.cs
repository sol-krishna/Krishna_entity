using Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataContext : DbContext
    {
        public DbSet<Constants> Constants { get; set; }
        public DbSet<Person> Users { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        private string dbPath;
        public DataContext()
        {
            dbPath = "C:\\Users\\keyur\\Documents\\Winter 2024 EFCore\\Day5";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={Path.Join(dbPath, "as.db")}");
        }
    }
}
