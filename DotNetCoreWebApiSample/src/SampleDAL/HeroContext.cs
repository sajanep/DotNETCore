using Microsoft.EntityFrameworkCore;
using SampleDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleDAL
{
    public class HeroContext: DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Hero>().ToTable("Hero");
        }

        public DbSet<Hero> Heroes { get; set; }
    }
}
