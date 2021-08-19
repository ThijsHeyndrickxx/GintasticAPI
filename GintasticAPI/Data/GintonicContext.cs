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
            builder.Entity<Gintonic>().Property(r => r.Taste).IsRequired();
            builder.Entity<Gintonic>().Property(r => r.Description).IsRequired().HasMaxLength(5000);


            //Another way to seed the database
            builder.Entity<Gintonic>().HasData(
                 new Gintonic { Id = 1, Name = "Grapefruit & pink peppercorn", Taste = "Sweet", Description="Fill your glass with ice, add 30 ml of grapefruit juice," +
                 "40 ml of gin, 200ml of tonic and finish of with a handfull of pink peppercorns to finish it off. "},
                 new Gintonic { Id = 2, Name = "Cucumber, Lime, Elderflower & Basil Gin", Taste = "Mediterranean", Description="Fill your glass with ice, add 50 ml of gin, 125 ml of tonic" +
                 "15 ml of elderflower liqeur, half a lime, half a cucumber and 2 to 3 leaves of fresh basil." }
  );
        }

        public DbSet<Gintonic> Gintonics { get; set; }
    }
}
