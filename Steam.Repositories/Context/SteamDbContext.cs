using System;
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

            modelBuilder.Entity<Publisher>().HasData(
                new Publisher()
                {
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490"),
                    Name = "Capcom"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("3817acf1-4920-4c77-b2c9-d4000be9703a"),
                    Name = "Sega"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("a2bc460c-ab39-4903-81df-367bbf5453eb"),
                    Name = "Electronic Arts"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("3cac1789-e877-48f7-8dc1-fd32dad85172"),
                    Name = "Microsoft"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("ad2f4d1c-7a67-448c-a3e8-74a7cc7813a5"),
                    Name = "Ubisoft"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("589c2fd3-2a74-4f4e-90f7-400d39edcb38"),
                    Name = "Square Enix"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("af821292-a1d9-4dc4-9d27-405a4f85e48a"),
                    Name = "Bandai Namco Entertainment"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("81d46aa2-d8a0-4dcb-82a7-9f32f05eddb3"),
                    Name = "THQ Nordic"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8"),
                    Name = "Red Barrel"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("098280de-4136-47a9-93c5-0fe594638105"),
                    Name = "Sony"
                }
        );



        }
    }
}