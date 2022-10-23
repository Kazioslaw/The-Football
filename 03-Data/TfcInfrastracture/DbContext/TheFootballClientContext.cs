using Microsoft.EntityFrameworkCore;
using TfcDomain.Models;

namespace TfcInfrastracture.DbContext
{
    public class TheFootballClientContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TheFootballClientContext(DbContextOptions<TheFootballClientContext> options)
            : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; } = default!;

        public DbSet<Match>? Matches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().ToTable("Club");
            modelBuilder.Entity<Match>().ToTable("Match");
        }
    }
}
