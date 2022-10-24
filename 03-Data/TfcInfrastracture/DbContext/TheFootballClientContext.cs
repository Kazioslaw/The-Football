using Microsoft.EntityFrameworkCore;
using TfcDomain.Models;

namespace TfcInfrastracture.DbContext
{
    public class TheFootballClientContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TheFootballClientContext()
        {

        }

        public TheFootballClientContext(DbContextOptions<TheFootballClientContext> options)
            : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; } = default!;
        public DbSet<Competition>? Competitions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<Match>? Matches { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                //TO DELETE - IT HAVE TO BE LOADED FROM APPSETINGS.JSON ONLY
                options.UseSqlServer("Server=(localdb)\\\\mssqllocaldb;Database=TheFootballClient;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Club>().ToTable("Club");
            modelBuilder.Entity<Match>().ToTable("Match");
        }
    }
}
