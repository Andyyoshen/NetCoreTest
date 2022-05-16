using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Models
{
    public class GISTest: DbContext
    {
        public GISTest() { }
        public GISTest(DbContextOptions<GISTest> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=D:\GIS\AndyGis.sqlite");
        }
        public DbSet<Taiwan> Taiwan { get; set; }
        public DbSet<town_moi_1100415> town_moi_1100415 { get; set; }
    }
}
