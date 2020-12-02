using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Steam.Entities;

namespace Steam.Repositories
{
    public class SteamDbContext : DbContext
    {
        public SteamDbContext(DbContextOptions<SteamDbContext> options) : base(options)
        {
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Publisher> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<GameGenre> GameGenres { get; set; }
        public DbSet<UserGame> UserGames { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapping Many to Many Relationships

            //Set the Primary Keys
            // User to UserGame && Game to UserGame
            modelBuilder.Entity<UserGame>()
                .HasKey(uG => new { uG.UserId, uG.GameId });

            modelBuilder.Entity<UserGame>()
                .HasOne(uG => uG.User)
                .WithMany(u => u.OwnedGames)
                .HasForeignKey(uG => uG.UserId);
            ;
            modelBuilder.Entity<UserGame>()
                .HasOne(uG => uG.Game)
                .WithMany(g => g.UsersWhoBoughtTheGame)
                .HasForeignKey(uG => uG.GameId);
            ;

            //Set the Primary Keys
            // User to UserGame && Game to UserGame
            modelBuilder.Entity<GameGenre>()
                .HasKey(gG => new { gG.GameId, gG.GenreId });

            modelBuilder.Entity<GameGenre>()
                .HasOne(gG => gG.Game)
                .WithMany(g => g.Genres)
                .HasForeignKey(gG => gG.GameId);
            ;
            modelBuilder.Entity<GameGenre>()
                .HasOne(gG => gG.Genre)
                .WithMany(g => g.Games)
                .HasForeignKey(gG => gG.GenreId);
            ;

        }

    }
}