using covidtrackerhnApi.Domain;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace covidtrackerhnApi.Context
{
    public class CovidTrackernHnContext:DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }

        public DbSet<CovidCase> CovidCases { get; set; }

        public CovidTrackernHnContext(DbContextOptions<CovidTrackernHnContext> options)
            : base(options)
        {
        }
        public CovidTrackernHnContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
            .Property(b => b.CountryId)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<State>()
            .Property(b => b.StateId)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<CovidCase>()
            .Property(b => b.CovidCaseId)
            .ValueGeneratedOnAdd();
        }   


    }
    
}