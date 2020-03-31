using covidtrackerhnApi.Domain;
using Microsoft.EntityFrameworkCore;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("User Id=postgres;Password=mypassword;Server=localhost;Port=5432;Database=covidtrackerhn;Integrated Security=true;Pooling=true;");
            }
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