using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDIMVC.Models
{
    public class FishingContext : DbContext
    {
        public DbSet<FishingBoat> FishingBoats { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            string connection = "server=localhost;database=fishing;trusted_connection=true;";
            optionsBuilder.UseSqlServer(connection);
            
        }
    }
}
