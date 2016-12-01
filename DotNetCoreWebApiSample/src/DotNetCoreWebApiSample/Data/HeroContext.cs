using DotNetCoreWebApiSample.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApiSample.Data
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
