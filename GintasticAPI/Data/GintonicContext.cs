using GintasticAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GintasticAPI.Data
{
    public class GintonicContext : DbContext
    {
        public GintonicContext(DbContextOptions<GintonicContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.Entity<Gintonic>().Property(r => r.Name).IsRequired().HasMaxLength(50);

            //Another way to seed the database
            builder.Entity<Gintonic>().HasData(
                 new Gintonic { Id = 1, Name = "Gintonic dry"},
                 new Gintonic { Id = 2, Name = "Gintonic sweet"}
  );
        }

        public DbSet<Gintonic> Gintonics { get; set; }
    }
}
