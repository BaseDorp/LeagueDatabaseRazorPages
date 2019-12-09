using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LeagueDatabase.Models;

namespace LeagueDatabase.Data
{
    public class GameContext : DbContext
    {
        public GameContext(DbContextOptions<GameContext> options)
             : base(options)
        {
        }

        public DbSet<Player> Player { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tournament>().ToTable("Tournement");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Player>().ToTable("Player");
        }
    }
}
