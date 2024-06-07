using Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Assignment_1
{
    public class DataContext : DbContext
    {
        public string DbPath { get; set; }

        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            DbPath = Path.Combine(path, "assignment.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogType> BlogTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
    }
}
