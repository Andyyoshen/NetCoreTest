using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
namespace WebApplication3.Models
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext() { }
        public CustomDbContext(DbContextOptions<CustomDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\AndyTest;Database=Test;user=sa;password=123456;Trusted_Connection=True");
        }
        public DbSet<Post> Post { get; set; }

    }
}
