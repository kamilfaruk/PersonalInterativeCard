using PersonalInterativeCard.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace PersonalInterativeCard.Data
{
    public class InteractiveCardDbContext : DbContext
    {
        public InteractiveCardDbContext(DbContextOptions<InteractiveCardDbContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        /// <summary>
        /// Db oluşma esnasında çalışır. Konfigurasynlar bu bölümde çalışır.
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InteractiveCardDbContext).Assembly);
        }
        public DbSet<Card> Card { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<Entities.Exception> Exception { get; set; }


    }
}