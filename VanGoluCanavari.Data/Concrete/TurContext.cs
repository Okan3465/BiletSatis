using Microsoft.EntityFrameworkCore;
using VanGoluCanavari.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanGoluCanavari.Data.Concrete
{
   public class TurContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Comment> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=VanDb");
        }
    }

    
}
