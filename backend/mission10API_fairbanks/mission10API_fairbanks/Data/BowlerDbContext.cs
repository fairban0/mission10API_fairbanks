using Microsoft.EntityFrameworkCore;
using mission10API_fairbanks.Data; 

namespace mission10API_fairbanks.Data
{
    public class BowlerDbContext : DbContext
    {
        public BowlerDbContext(DbContextOptions<BowlerDbContext> options)
            : base(options) { }

        public DbSet<Bowler> Bowlers { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bowler>()
                .HasOne(b => b.Team)
                .WithMany(t => t.Bowlers)
                .HasForeignKey(b => b.TeamID)
                .OnDelete(DeleteBehavior.Cascade);  
        }
    }
}


