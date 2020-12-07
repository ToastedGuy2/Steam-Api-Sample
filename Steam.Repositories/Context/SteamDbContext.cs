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
                    Name = "Xbox Game Studios"
                },
                new Publisher()
                {
                    PublisherId = Guid.Parse("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"),
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
                    Name = "PlayStation Mobile, Inc."
                }
        );

            modelBuilder.Entity<Game>().HasData(
                // Capcom
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Resident Evil (Remake)",
                    Price = 19.99,
                    ReleaseDate = new DateTime(2002, 3, 22),
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490")
                },
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Resident Evil 2 (Remake)",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2019, 1, 25),
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490")
                },
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Resident Evil 3 (Remake)",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2020, 4, 3),
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490")
                },
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Resident Evil 4",
                    Price = 29.99,
                    ReleaseDate = new DateTime(2005, 1, 11),
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490")
                }
                // Sega
                ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Sonic the Hedgehog",
                    Price = 4.99,
                    ReleaseDate = new DateTime(1999, 1, 11),
                    PublisherId = Guid.Parse("3817acf1-4920-4c77-b2c9-d4000be9703a")
                }
                // Electronic Arts
                ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Mass Effect 2",
                    Price = 9.99,
                    ReleaseDate = new DateTime(2011, 6, 12),
                    PublisherId = Guid.Parse("a2bc460c-ab39-4903-81df-367bbf5453eb")
                }
                ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "The Sims 4: Snowy Escape",
                    Price = 9.99,
                    ReleaseDate = new DateTime(2020, 11, 13),
                    PublisherId = Guid.Parse("a2bc460c-ab39-4903-81df-367bbf5453eb")
                }
                ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Need for Speed: Hot Pursuit Remastered",
                    Price = 9.99,
                    ReleaseDate = new DateTime(2020, 11, 6),
                    PublisherId = Guid.Parse("a2bc460c-ab39-4903-81df-367bbf5453eb")
                }
               // Xbox Game Studios
               ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Halo: The Master Chief Collection",
                    Price = 49.99,
                    ReleaseDate = new DateTime(2019, 12, 3),
                    PublisherId = Guid.Parse("3cac1789-e877-48f7-8dc1-fd32dad85172")
                }

                //    Ubisoft
                ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Watch Dogs: Legion",
                    Price = 60.00,
                    ReleaseDate = new DateTime(2020, 12, 7),
                    PublisherId = Guid.Parse("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5")
                }
                ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Assassin's Creed Valhalla",
                    Price = 59.99,
                    ReleaseDate = new DateTime(2020, 12, 3),
                    PublisherId = Guid.Parse("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5")
                }
               //    Squarenix
               ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Final Fantasy XVI",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2020, 12, 1),
                    PublisherId = Guid.Parse("589c2fd3-2a74-4f4e-90f7-400d39edcb38")
                }
                ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Dragon Quest Tact",
                    Price = 59.99,
                    ReleaseDate = new DateTime(2020, 12, 12),
                    PublisherId = Guid.Parse("589c2fd3-2a74-4f4e-90f7-400d39edcb38")
                }
                ,
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Kingdom Hearts: Melody of Memory",
                    Price = 19.99,
                    ReleaseDate = new DateTime(2020, 11, 1),
                    PublisherId = Guid.Parse("589c2fd3-2a74-4f4e-90f7-400d39edcb38")
                }
                ,
            // Bandai Namco Entertainment
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Dragon Ball Z: Kakarot",
                    Price = 99.99,
                    ReleaseDate = new DateTime(2020, 11, 12),
                    PublisherId = Guid.Parse("af821292-a1d9-4dc4-9d27-405a4f85e48a")
                },

                // THQ Nordic
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Darksiders 3",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2019, 7, 1),
                    PublisherId = Guid.Parse("81d46aa2-d8a0-4dcb-82a7-9f32f05eddb3")
                },
            // Red Barrel

                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Outlast",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2013, 1, 1),
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8")
                },
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Outlast Whistleblower",
                    Price = 19.99,
                    ReleaseDate = new DateTime(2013, 8, 22),
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8")
                },
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Outlast 2",
                    Price = 59.99,
                    ReleaseDate = new DateTime(2017, 3, 10),
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8")
                },
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Outlast Trials",
                    Price = 99.99,
                    ReleaseDate = new DateTime(2021, 8, 12),
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8")
                },
                // PlayStation Mobile, Inc.
                new Game()
                {
                    GameId = Guid.NewGuid(),
                    Name = "Horizon Zero Dawn™ Complete Edition",
                    Price = 99.99,
                    ReleaseDate = new DateTime(2020, 10, 10),
                    PublisherId = Guid.Parse("098280de-4136-47a9-93c5-0fe594638105")
                }
            );

        }
    }
}