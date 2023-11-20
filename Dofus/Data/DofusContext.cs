using Dofus.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Dofus.Data
{
    public class DofusContext : DbContext
    {
        public DofusContext(DbContextOptions<DofusContext> options) : base(options) { }

        public DbSet<News> NewsItems { get; set; }
    }
}
