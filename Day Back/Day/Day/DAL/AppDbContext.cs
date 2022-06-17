using Day.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
        }
        public DbSet<App> Apps { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Web> Webs { get; set; }
    }
}
