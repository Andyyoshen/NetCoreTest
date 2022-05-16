using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class PostSqlContext : DbContext
    {
        public PostSqlContext() { }
        public PostSqlContext(DbContextOptions<CustomDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=localhost;Database=TestCourse;port=5432;User Id=postgres;Password=123456", x => x.UseNetTopologySuite());
        }
        public DbSet<town_moi_1100415> town_moi_1100415 { get; set; }

    }
}
