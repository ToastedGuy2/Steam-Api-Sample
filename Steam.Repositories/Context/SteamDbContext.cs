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
                    GameId = Guid.Parse("b7a027dc-fa0a-444b-b903-2e3ad85a76bd"),
                    Name = "Resident Evil (Remake)",
                    Description = "In 1998 a special forces team is sent to investigate some bizarre murders on the outskirts of Raccoon City. Upon arriving they are attacked by a pack of blood-thirsty dogs and are forced to take cover in a nearby mansion. But the scent of death hangs heavy in the air. Supplies are scarce as they struggle to stay alive",
                    Price = 19.99,
                    ReleaseDate = new DateTime(2002, 3, 22),
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490")
                },
                new Game()
                {
                    GameId = Guid.Parse("e0f4474b-b9d1-4b5b-8a01-470908300090"),
                    Name = "Resident Evil 2 (Remake)",
                    Description = "In Resident Evil 2, the classic action, tense exploration, and puzzle solving gameplay that defined the Resident Evil series returns. Players join rookie police officer Leon Kennedy and college student Claire Redfield, who are thrust together by a disastrous outbreak in Raccoon City that transformed its population into deadly zombies. Both Leon and Claire have their own separate playable campaigns, allowing players to see the story from both characters’ perspectives. The fate of these two fan favorite characters is in players hands as they work together to survive and get to the bottom of what is behind the terrifying attack on the city. Will they make it out alive?",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2019, 1, 25),
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490")
                },
                new Game()
                {
                    GameId = Guid.Parse("4013b6ad-0aef-4d13-9122-514cd3c6fb78"),
                    Name = "Resident Evil 3 (Remake)",
                    Description = "Jill Valentine is one of the last remaining people in Raccoon City to witness the atrocities Umbrella performed. To stop her, Umbrella unleashes their ultimate secret weapon: Nemesis! Also includes Resident Evil Resistance, a new 1 vs 4 online multiplayer game set in the Resident Evil universe. ",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2020, 4, 3),
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490")
                },
                new Game()
                {
                    GameId = Guid.Parse("e27fff89-a17b-4d6a-b108-869703ecb3cd"),
                    Name = "Resident Evil 4",
                    Description = "Special agent Leon S. Kennedy is sent on a mission to rescue the U.S. President’s daughter who has been kidnapped.",
                    Price = 29.99,
                    ReleaseDate = new DateTime(2005, 1, 11),
                    PublisherId = Guid.Parse("97f4b78d-5752-413f-9f2e-0bfa4947d490")
                }
                // Sega
                ,
                new Game()
                {
                    GameId = Guid.Parse("139320ef-df4e-473a-ada0-b9a548dcd68e"),
                    Name = "Sonic the Hedgehog",
                    Description = "The ultimate celebration of 20 Years of Sonic gaming, Sonic Generations delivers the definitive experience for Sonic fans new and old.Sonic’s universe is thrown into chaos when a mysterious new power comes into force, creating ‘time holes’ which take Sonic and his friends back in time. Whilst there, Sonic runs into some very familiar characters from his past including a younger version of himself! Now they must team up to defeat their enemies, save their friends, and find out who is behind this diabolical deed",
                    Price = 4.99,
                    ReleaseDate = new DateTime(1999, 1, 11),
                    PublisherId = Guid.Parse("3817acf1-4920-4c77-b2c9-d4000be9703a")
                }
                // Electronic Arts
                ,
                new Game()
                {
                    GameId = Guid.Parse("1f552387-3728-413d-bf0f-835bfa6c2738"),
                    Name = "Mass Effect 2",
                    Description = "Recruit. Explore. Control.Two years after Commander Shepard repelled invading Reapers bent on the destruction of organic life, a mysterious new enemy has emerged. On the fringes of known space, something is silently abducting entire human colonies.",
                    Price = 9.99,
                    ReleaseDate = new DateTime(2011, 6, 12),
                    PublisherId = Guid.Parse("a2bc460c-ab39-4903-81df-367bbf5453eb")
                }
                ,
                new Game()
                {
                    GameId = Guid.Parse("4182ee1c-864a-495d-b959-8987017d97b1"),
                    Name = "The Sims 4: Snowy Escape",
                    Description = "The Sims 4: Snowy Escape is the tenth expansion pack for The Sims 4. It was announced on October 19, 2020, and its trailer premiered the next day.[1] It was released on November 13, 2020 for all platforms.The expansion centers on the world of Mt. Komorebi, a snowy, Japanese-inspired mountainous area that features activities such as snowboarding, skiing, sledding and mountain climbing, as well as natural hot springs. Other features include the lifestyles game mechanic and new Japanese-inspired food and architecture. The Sims 4: Seasons is not a requirement for the pack.[2] This pack features various elements of Vacation Island from The Sims: Vacation, Takemizu Village and Three Lakes from The Sims 2: Bon Voyage and Shang Simla from The Sims 3: World Adventures, as well as Mount. Fuji in The Sims Online and Melbourne in The Sims 2 for console. ",
                    Price = 9.99,
                    ReleaseDate = new DateTime(2020, 11, 13),
                    PublisherId = Guid.Parse("a2bc460c-ab39-4903-81df-367bbf5453eb")
                }
                ,
                new Game()
                {
                    GameId = Guid.Parse("36697005-ce0a-40b2-ba06-99c33263016a"),
                    Name = "Need for Speed: Hot Pursuit Remastered",
                    Description = "It's time to reignite the pursuit in need for speed: hot pursuit remastered. Feel the thrill of the Chase and the rush of escape in need for speed: hot pursuit remastered. Unleash a savage sense of speed both as an Outlaw and a cop in the world's hottest high-performance cars. Outsmart the heat or take down lawbreakers with the tactical weaponry at your disposal in a heart-pumping, socially competitive racing experience. Updated with enhanced visuals, Cross-Platform multiplayer. Including the asynchronous competition powered by Auto log - Plus all main DLC, this is the ultimate EDITION of Criterion games' Critically acclaimed need for speed debut. It's time to reignite the pursuit.",
                    Price = 9.99,
                    ReleaseDate = new DateTime(2020, 11, 6),
                    PublisherId = Guid.Parse("a2bc460c-ab39-4903-81df-367bbf5453eb")
                }
               // Xbox Game Studios
               ,
                new Game()
                {
                    GameId = Guid.Parse("f1ac6f57-c10d-4700-91ce-cb5d9841a7bc"),
                    Name = "Halo: The Master Chief Collection",
                    Description = "The Master Chief’s iconic journey includes six games, built for PC and collected in a single integrated experience where each game is delivered over time. Whether you’re a long-time fan or meeting Spartan 117 for the first time, The Master Chief Collection is the definitive Halo gaming experience.",
                    Price = 49.99,
                    ReleaseDate = new DateTime(2019, 12, 3),
                    PublisherId = Guid.Parse("3cac1789-e877-48f7-8dc1-fd32dad85172")
                }

                //    Ubisoft
                ,
                new Game()
                {
                    GameId = Guid.Parse("a494d332-ab54-45bd-8ddf-722559d9705a"),
                    Name = "Watch Dogs: Legion",
                    Description = "Watch Dogs: Legion is a 2020 action-adventure game published by Ubisoft and developed by its Toronto studio. It is the third instalment in the Watch Dogs series, and the sequel to 2016's Watch Dogs 2. Set within a fictionalised representation of a future, dystopian London, the game's story focuses on the hacker group DedSec as they seek to clear their names for a series of bombings they have been framed for, as well as liberate its citizens from the control of an oppressive private military company, which turned London into a surveillance state in the aftermath of the bombings. ",
                    Price = 60.00,
                    ReleaseDate = new DateTime(2020, 12, 7),
                    PublisherId = Guid.Parse("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5")
                }
                ,
                new Game()
                {
                    GameId = Guid.Parse("19e17050-6a29-4b8a-b863-87ee5ed041cb"),
                    Name = "Assassin's Creed Valhalla",
                    Description = "Become Eivor, a mighty Viking raider and lead your clan from the harsh shores of Norway to a new home amid the lush farmlands of ninth-century England. Explore a beautiful, mysterious open world where you'll face brutal enemies, raid fortresses, build your clan's new settlement, and forge alliances to win glory and earn a place in Valhalla. \nEngland in the age of the Vikings is a fractured nation of petty lords and warring kingdoms. Beneath the chaos lies a rich and untamed land waiting for a new conqueror. Will it be you?",
                    Price = 59.99,
                    ReleaseDate = new DateTime(2020, 12, 3),
                    PublisherId = Guid.Parse("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5")
                }
               //    Squarenix
               ,
                new Game()
                {
                    GameId = Guid.Parse("24514607-a2f8-4251-a011-97a9b3a62dfd"),
                    Name = "Final Fantasy XVI",
                    Description = "Final Fantasy XVI is an action role-playing game set in the fantasy world of Valisthea, where the people live comfortably thanks to mountains of crystal called the Mothercrystals. The world is controlled by six factions: the Grand Duchy of Rosaria, the Holy Empire of Sanbreque, the Kingdom of Waloed, the Dhalmekian Republic, the Iron Kingdom, and the Crystalline Dominion. A central part of the plot is Eikons, summoned monsters controlled by or manifesting through humans called Dominants.\nThe main cast includes Clive Rosfield, the firstborn son of the Archduke of Rosaria who embarks on a quest for revenge after tragic events involving the dark Eikon Ifrit; Joshua Rosfield, Clive's younger brother, Dominant of the Eikon Phoenix, and heir apparent to Rosaria; and Jill Warrick, a woman from the fallen Northern Territories who is Clive and Joshua's foster sister and confidant.[2] Gameplay has Clive fighting using a combination of melee-based sword attacks and magical abilities.",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2020, 12, 1),
                    PublisherId = Guid.Parse("589c2fd3-2a74-4f4e-90f7-400d39edcb38")
                }
                ,
                new Game()
                {
                    GameId = Guid.Parse("b678411e-f2b2-451e-a8f5-60e723bec245"),
                    Name = "Dragon Quest Tact",
                    Description = "Long ago in the days of old, an evil Demon King ruled the world of Orchesterra until a man and woman with the Tact of Legend took a stand against the King with their fellow monster companions.\nThis man and woman led their companions to battle against the King and the King ended up being sealed away.\nThe world returned to peace but the stories of the man and woman were forgotten... \nMuch time has passed since...\nAnd the Demon King's hand prepares to rule once again... ",
                    Price = 59.99,
                    ReleaseDate = new DateTime(2020, 12, 12),
                    PublisherId = Guid.Parse("589c2fd3-2a74-4f4e-90f7-400d39edcb38")
                }
                ,
                new Game()
                {
                    GameId = Guid.Parse("e3c89efe-871c-4f4a-aecd-f2e620ffb39a"),
                    Name = "Kingdom Hearts: Melody of Memory",
                    Description = "Following Sora's disappearance, Kairi enters a deep sleep under Ansem the Wise's observation, creating a dream world from her memories of Sora to search for clues to his whereabouts within her own heart. Towards the end of her dream, Kairi confronts an illusion of Xehanort, who nearly overpowers her until Sora remotely takes control of her body and defeats him. Before Kairi reawakens, Xehanort reminds her of the time in her childhood when he sent her away from Radiant Garden, during which he mentioned a world on the \"other side\"; Kairi reports her findings to Ansem, who reasons the \"other side\" to mean a fictional world beyond their reality. Kairi is then approached by the Fairy Godmother, who sends her and Riku to the Final World to meet the heart of a girl from the other reality.[b] Riku explains his dream of a modern metropolis to the girl, who recognizes it as a city in her world called Quadratum, allowing Riku to open a portal to the other reality and begin his search for Sora, while Kairi remains behind to resume her Keyblade training. In a post-credits scene, Kairi decides to study under Aqua, while Yen Sid sends Donald and Goofy to inform the rest of their comrades of their progress, and Mickey to Scala ad Caelum to investigate ancient Keyblade Masters and how they may be connected to the other reality. ",
                    Price = 19.99,
                    ReleaseDate = new DateTime(2020, 11, 1),
                    PublisherId = Guid.Parse("589c2fd3-2a74-4f4e-90f7-400d39edcb38")
                }
                ,
            // Bandai Namco Entertainment
                new Game()
                {
                    GameId = Guid.Parse("8bfe8fd0-3487-4502-a2a7-f593fbf6937a"),
                    Name = "Dragon Ball Z: Kakarot",
                    Description = "Relive the story of Goku and other Z Fighters in DRAGON BALL Z: KAKAROT! Beyond the epic battles, experience life in the DRAGON BALL Z world as you fight, fish, eat, and train with Goku, Gohan, Vegeta and others.",
                    Price = 99.99,
                    ReleaseDate = new DateTime(2020, 11, 12),
                    PublisherId = Guid.Parse("af821292-a1d9-4dc4-9d27-405a4f85e48a")
                },

                // THQ Nordic
                new Game()
                {
                    GameId = Guid.Parse("b490988a-c1cb-4a3e-a96a-3b0626c825a6"),
                    Name = "Darksiders 3",
                    Description = "Return to an apocalyptic Earth in Darksiders III, a hack-n-slash Action Adventure where players assume the role of FURY in her quest to hunt down and dispose of the Seven Deadly Sins. The most enigmatic of the Four Horsemen, FURY must bring balance to the forces that now ravage Earth. ",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2019, 7, 1),
                    PublisherId = Guid.Parse("81d46aa2-d8a0-4dcb-82a7-9f32f05eddb3")
                },
            // Red Barrel

                new Game()
                {
                    GameId = Guid.Parse("8f1ff312-8202-4dcc-bf05-3cfe812bdca8"),
                    Name = "Outlast",
                    Description = "In the remote mountains of Colorado, horrors wait inside Mount Massive Asylum. A long-abandoned home for the mentally ill, recently re-opened by the “research and charity” branch of the transnational Murkoff Corporation, the asylum has been operating in strict secrecy… until now.\nActing on a tip from an anonymous source, independent journalist Miles Upshur breaks into the facility, and what he discovers walks a terrifying line between science and religion, nature and something else entirely. Once inside, his only hope of escape lies with the terrible truth at the heart of Mount Massive.\nOutlast is a true survival horror experience which aims to show that the most terrifying monsters of all come from the human mind. ",
                    Price = 39.99,
                    ReleaseDate = new DateTime(2013, 1, 1),
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8")
                },
                new Game()
                {
                    GameId = Guid.Parse("91e65ce8-3e78-46db-906c-41d918253467"),
                    Name = "Outlast Whistleblower",
                    Description = "Whistleblower will let you play as Waylon Park, a software engineer under contract with Murkoff and the man who emailed journalists around the world - including Miles - at the beginning of Outlast. Spending a couple of weeks at Mount Massive, during which he was unable to even talk to his wife and son thanks to strict security protocols, Waylon developed a deep-seated distrust of the profit-motivated scientists and doctors leading dangerous and irresponsible experiments on their patients. Identifying with those poor souls fueled Waylon's anger, and set the stage for his unmasking of Mount Massive's rotten core.\nAlthough Whistleblower tells the story that led to Outlast, it will actually stretch past the events of the first game to show the final chapter in Mount Massive Asylum's story. ",
                    Price = 19.99,
                    ReleaseDate = new DateTime(2013, 8, 22),
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8")
                },
                new Game()
                {
                    GameId = Guid.Parse("a0fa0254-fe78-4eed-9c62-f514ea93550f"),
                    Name = "Outlast 2",
                    Description = "You are Blake Langermann, a cameraman working with your wife, Lynn. The two of you are investigative journalists willing to take risks and dig deep to uncover the stories no one else will dare touch.\nYou're following a trail of clues that started with the seemingly impossible murder of a pregnant woman known only as Jane Doe.The investigation has lead you miles into the Arizona desert, to a darkness so deep that no one could shed light upon it, and a corruption so profound that going mad may be the only sane thing to do. ",
                    Price = 59.99,
                    ReleaseDate = new DateTime(2017, 3, 10),
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8")
                },
                new Game()
                {
                    GameId = Guid.Parse("a2ab7c4f-9e87-4fe9-b118-cdbbc3dad657"),
                    Name = "Outlast Trials",
                    Description = "Set in the era of the Cold War, human guinea pigs are involuntarily recruited by the good folks at the Murkoff Corporation to test advanced methods of brainwashing and mind control. In a world of distrust, fear, and violence, your morals will be challenged, your endurance tested, and your sanity crushed. All in the name of progress, science, and profit. ",
                    Price = 99.99,
                    ReleaseDate = new DateTime(2021, 8, 12),
                    PublisherId = Guid.Parse("9d30ed06-41be-4e27-b16c-34e65015dcc8")
                },
                // PlayStation Mobile, Inc.
                new Game()
                {
                    GameId = Guid.Parse("82349e02-c2c7-4781-8629-1501e943e99d"),
                    Name = "Experience Aloy’s legendary quest to unravel the mysteries of a future Earth ruled by Machines. Use devastating tactical attacks against your prey and explore a majestic open world in this award-winning action RPG! ",
                    Description = "",
                    Price = 99.99,
                    ReleaseDate = new DateTime(2020, 10, 10),
                    PublisherId = Guid.Parse("098280de-4136-47a9-93c5-0fe594638105")
                }
            );

        }
    }
}