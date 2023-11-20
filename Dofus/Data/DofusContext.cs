using Dofus.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Dofus.Data
{
    public class DofusContext : DbContext
    {
        public DofusContext(DbContextOptions<DofusContext> options) : base(options) { }

        public DbSet<News> NewsItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure the 'News' entity to map to the 'News' table
            modelBuilder.Entity<News>().ToTable("News");
        }
    }
}
