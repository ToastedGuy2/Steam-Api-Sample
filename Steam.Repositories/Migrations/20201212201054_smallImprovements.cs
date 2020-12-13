using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Steam.Repositories.Migrations
{
    public partial class smallImprovements : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("05030f44-1cc1-4705-8425-dff570338af0"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("0821cc45-1c31-48a9-933e-4a01d9128d29"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("122abc80-dd11-482c-8a9e-84d64491c9f8"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("16d88b83-d04f-4f1c-8f0f-da3caaf88f9c"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("38e31c2b-2fb5-4674-87a6-5058044776e6"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("39b1c665-85fc-497b-ad67-6e564378d7b6"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("3b90fc64-88da-4a94-897a-14ce088cfc11"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("5a8f9dd9-eb68-4432-ab85-cea83ad8c081"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("5fad36b3-deb3-4c6a-8308-504a1d8caa28"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("6cdb208d-5c10-4b3c-bc7b-59a8969090ed"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("757bd454-56bb-4ea7-82a6-44b908865009"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("761ee81a-aebd-48fc-a76d-14bd94d05203"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("842fa951-5862-47c4-8247-2fd58f9e925b"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("84f75268-f146-4d74-ae4b-9f403ffc8b5d"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("af4226d2-a907-4cc9-baaf-6ec82a6d6ba4"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("bb697f12-3466-4b1d-a653-5fa47ce73b37"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("bd162050-adb1-4aaf-92ac-4ed34365acd6"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("d3b9353b-81fb-4440-bfde-02477d749523"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("d88627ba-cbdf-442d-a292-2d9391fa6b01"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("dc436a80-ad4f-4629-ae05-3d3e3b703e9b"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("efe0895e-5734-4bd1-b57f-4c286b209df4"));

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Publisher",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genre",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Game",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Game",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Description", "Name", "Price", "PublisherId", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("b7a027dc-fa0a-444b-b903-2e3ad85a76bd"), "In 1998 a special forces team is sent to investigate some bizarre murders on the outskirts of Raccoon City. Upon arriving they are attacked by a pack of blood-thirsty dogs and are forced to take cover in a nearby mansion. But the scent of death hangs heavy in the air. Supplies are scarce as they struggle to stay alive", "Resident Evil (Remake)", 19.989999999999998, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("a0fa0254-fe78-4eed-9c62-f514ea93550f"), @"You are Blake Langermann, a cameraman working with your wife, Lynn. The two of you are investigative journalists willing to take risks and dig deep to uncover the stories no one else will dare touch.
                You're following a trail of clues that started with the seemingly impossible murder of a pregnant woman known only as Jane Doe.The investigation has lead you miles into the Arizona desert, to a darkness so deep that no one could shed light upon it, and a corruption so profound that going mad may be the only sane thing to do. ", "Outlast 2", 59.990000000000002, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2017, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("91e65ce8-3e78-46db-906c-41d918253467"), @"Whistleblower will let you play as Waylon Park, a software engineer under contract with Murkoff and the man who emailed journalists around the world - including Miles - at the beginning of Outlast. Spending a couple of weeks at Mount Massive, during which he was unable to even talk to his wife and son thanks to strict security protocols, Waylon developed a deep-seated distrust of the profit-motivated scientists and doctors leading dangerous and irresponsible experiments on their patients. Identifying with those poor souls fueled Waylon's anger, and set the stage for his unmasking of Mount Massive's rotten core.
                Although Whistleblower tells the story that led to Outlast, it will actually stretch past the events of the first game to show the final chapter in Mount Massive Asylum's story. ", "Outlast Whistleblower", 19.989999999999998, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2013, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("8f1ff312-8202-4dcc-bf05-3cfe812bdca8"), @"In the remote mountains of Colorado, horrors wait inside Mount Massive Asylum. A long-abandoned home for the mentally ill, recently re-opened by the “research and charity” branch of the transnational Murkoff Corporation, the asylum has been operating in strict secrecy… until now.
                Acting on a tip from an anonymous source, independent journalist Miles Upshur breaks into the facility, and what he discovers walks a terrifying line between science and religion, nature and something else entirely. Once inside, his only hope of escape lies with the terrible truth at the heart of Mount Massive.
                Outlast is a true survival horror experience which aims to show that the most terrifying monsters of all come from the human mind. ", "Outlast", 39.990000000000002, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("b490988a-c1cb-4a3e-a96a-3b0626c825a6"), "Return to an apocalyptic Earth in Darksiders III, a hack-n-slash Action Adventure where players assume the role of FURY in her quest to hunt down and dispose of the Seven Deadly Sins. The most enigmatic of the Four Horsemen, FURY must bring balance to the forces that now ravage Earth. ", "Darksiders 3", 39.990000000000002, new Guid("81d46aa2-d8a0-4dcb-82a7-9f32f05eddb3"), new DateTimeOffset(new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("8bfe8fd0-3487-4502-a2a7-f593fbf6937a"), "Relive the story of Goku and other Z Fighters in DRAGON BALL Z: KAKAROT! Beyond the epic battles, experience life in the DRAGON BALL Z world as you fight, fish, eat, and train with Goku, Gohan, Vegeta and others.", "Dragon Ball Z: Kakarot", 99.989999999999995, new Guid("af821292-a1d9-4dc4-9d27-405a4f85e48a"), new DateTimeOffset(new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("e3c89efe-871c-4f4a-aecd-f2e620ffb39a"), "Following Sora's disappearance, Kairi enters a deep sleep under Ansem the Wise's observation, creating a dream world from her memories of Sora to search for clues to his whereabouts within her own heart. Towards the end of her dream, Kairi confronts an illusion of Xehanort, who nearly overpowers her until Sora remotely takes control of her body and defeats him. Before Kairi reawakens, Xehanort reminds her of the time in her childhood when he sent her away from Radiant Garden, during which he mentioned a world on the \"other side\"; Kairi reports her findings to Ansem, who reasons the \"other side\" to mean a fictional world beyond their reality. Kairi is then approached by the Fairy Godmother, who sends her and Riku to the Final World to meet the heart of a girl from the other reality.[b] Riku explains his dream of a modern metropolis to the girl, who recognizes it as a city in her world called Quadratum, allowing Riku to open a portal to the other reality and begin his search for Sora, while Kairi remains behind to resume her Keyblade training. In a post-credits scene, Kairi decides to study under Aqua, while Yen Sid sends Donald and Goofy to inform the rest of their comrades of their progress, and Mickey to Scala ad Caelum to investigate ancient Keyblade Masters and how they may be connected to the other reality. ", "Kingdom Hearts: Melody of Memory", 19.989999999999998, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("b678411e-f2b2-451e-a8f5-60e723bec245"), @"Long ago in the days of old, an evil Demon King ruled the world of Orchesterra until a man and woman with the Tact of Legend took a stand against the King with their fellow monster companions.
                This man and woman led their companions to battle against the King and the King ended up being sealed away.
                The world returned to peace but the stories of the man and woman were forgotten... 
                Much time has passed since...
                And the Demon King's hand prepares to rule once again... ", "Dragon Quest Tact", 59.990000000000002, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("24514607-a2f8-4251-a011-97a9b3a62dfd"), @"Final Fantasy XVI is an action role-playing game set in the fantasy world of Valisthea, where the people live comfortably thanks to mountains of crystal called the Mothercrystals. The world is controlled by six factions: the Grand Duchy of Rosaria, the Holy Empire of Sanbreque, the Kingdom of Waloed, the Dhalmekian Republic, the Iron Kingdom, and the Crystalline Dominion. A central part of the plot is Eikons, summoned monsters controlled by or manifesting through humans called Dominants.
                The main cast includes Clive Rosfield, the firstborn son of the Archduke of Rosaria who embarks on a quest for revenge after tragic events involving the dark Eikon Ifrit; Joshua Rosfield, Clive's younger brother, Dominant of the Eikon Phoenix, and heir apparent to Rosaria; and Jill Warrick, a woman from the fallen Northern Territories who is Clive and Joshua's foster sister and confidant.[2] Gameplay has Clive fighting using a combination of melee-based sword attacks and magical abilities.", "Final Fantasy XVI", 39.990000000000002, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("a2ab7c4f-9e87-4fe9-b118-cdbbc3dad657"), "Set in the era of the Cold War, human guinea pigs are involuntarily recruited by the good folks at the Murkoff Corporation to test advanced methods of brainwashing and mind control. In a world of distrust, fear, and violence, your morals will be challenged, your endurance tested, and your sanity crushed. All in the name of progress, science, and profit. ", "Outlast Trials", 99.989999999999995, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("19e17050-6a29-4b8a-b863-87ee5ed041cb"), @"Become Eivor, a mighty Viking raider and lead your clan from the harsh shores of Norway to a new home amid the lush farmlands of ninth-century England. Explore a beautiful, mysterious open world where you'll face brutal enemies, raid fortresses, build your clan's new settlement, and forge alliances to win glory and earn a place in Valhalla. 
                England in the age of the Vikings is a fractured nation of petty lords and warring kingdoms. Beneath the chaos lies a rich and untamed land waiting for a new conqueror. Will it be you?", "Assassin's Creed Valhalla", 59.990000000000002, new Guid("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"), new DateTimeOffset(new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("f1ac6f57-c10d-4700-91ce-cb5d9841a7bc"), "The Master Chief’s iconic journey includes six games, built for PC and collected in a single integrated experience where each game is delivered over time. Whether you’re a long-time fan or meeting Spartan 117 for the first time, The Master Chief Collection is the definitive Halo gaming experience.", "Halo: The Master Chief Collection", 49.990000000000002, new Guid("3cac1789-e877-48f7-8dc1-fd32dad85172"), new DateTimeOffset(new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("36697005-ce0a-40b2-ba06-99c33263016a"), "It's time to reignite the pursuit in need for speed: hot pursuit remastered. Feel the thrill of the Chase and the rush of escape in need for speed: hot pursuit remastered. Unleash a savage sense of speed both as an Outlaw and a cop in the world's hottest high-performance cars. Outsmart the heat or take down lawbreakers with the tactical weaponry at your disposal in a heart-pumping, socially competitive racing experience. Updated with enhanced visuals, Cross-Platform multiplayer. Including the asynchronous competition powered by Auto log - Plus all main DLC, this is the ultimate EDITION of Criterion games' Critically acclaimed need for speed debut. It's time to reignite the pursuit.", "Need for Speed: Hot Pursuit Remastered", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("4182ee1c-864a-495d-b959-8987017d97b1"), "The Sims 4: Snowy Escape is the tenth expansion pack for The Sims 4. It was announced on October 19, 2020, and its trailer premiered the next day.[1] It was released on November 13, 2020 for all platforms.The expansion centers on the world of Mt. Komorebi, a snowy, Japanese-inspired mountainous area that features activities such as snowboarding, skiing, sledding and mountain climbing, as well as natural hot springs. Other features include the lifestyles game mechanic and new Japanese-inspired food and architecture. The Sims 4: Seasons is not a requirement for the pack.[2] This pack features various elements of Vacation Island from The Sims: Vacation, Takemizu Village and Three Lakes from The Sims 2: Bon Voyage and Shang Simla from The Sims 3: World Adventures, as well as Mount. Fuji in The Sims Online and Melbourne in The Sims 2 for console. ", "The Sims 4: Snowy Escape", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("1f552387-3728-413d-bf0f-835bfa6c2738"), "Recruit. Explore. Control.Two years after Commander Shepard repelled invading Reapers bent on the destruction of organic life, a mysterious new enemy has emerged. On the fringes of known space, something is silently abducting entire human colonies.", "Mass Effect 2", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2011, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("139320ef-df4e-473a-ada0-b9a548dcd68e"), "The ultimate celebration of 20 Years of Sonic gaming, Sonic Generations delivers the definitive experience for Sonic fans new and old.Sonic’s universe is thrown into chaos when a mysterious new power comes into force, creating ‘time holes’ which take Sonic and his friends back in time. Whilst there, Sonic runs into some very familiar characters from his past including a younger version of himself! Now they must team up to defeat their enemies, save their friends, and find out who is behind this diabolical deed", "Sonic the Hedgehog", 4.9900000000000002, new Guid("3817acf1-4920-4c77-b2c9-d4000be9703a"), new DateTimeOffset(new DateTime(1999, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("e27fff89-a17b-4d6a-b108-869703ecb3cd"), "Special agent Leon S. Kennedy is sent on a mission to rescue the U.S. President’s daughter who has been kidnapped.", "Resident Evil 4", 29.989999999999998, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2005, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("4013b6ad-0aef-4d13-9122-514cd3c6fb78"), "Jill Valentine is one of the last remaining people in Raccoon City to witness the atrocities Umbrella performed. To stop her, Umbrella unleashes their ultimate secret weapon: Nemesis! Also includes Resident Evil Resistance, a new 1 vs 4 online multiplayer game set in the Resident Evil universe. ", "Resident Evil 3 (Remake)", 39.990000000000002, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("e0f4474b-b9d1-4b5b-8a01-470908300090"), "In Resident Evil 2, the classic action, tense exploration, and puzzle solving gameplay that defined the Resident Evil series returns. Players join rookie police officer Leon Kennedy and college student Claire Redfield, who are thrust together by a disastrous outbreak in Raccoon City that transformed its population into deadly zombies. Both Leon and Claire have their own separate playable campaigns, allowing players to see the story from both characters’ perspectives. The fate of these two fan favorite characters is in players hands as they work together to survive and get to the bottom of what is behind the terrifying attack on the city. Will they make it out alive?", "Resident Evil 2 (Remake)", 39.990000000000002, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("a494d332-ab54-45bd-8ddf-722559d9705a"), "Watch Dogs: Legion is a 2020 action-adventure game published by Ubisoft and developed by its Toronto studio. It is the third instalment in the Watch Dogs series, and the sequel to 2016's Watch Dogs 2. Set within a fictionalised representation of a future, dystopian London, the game's story focuses on the hacker group DedSec as they seek to clear their names for a series of bombings they have been framed for, as well as liberate its citizens from the control of an oppressive private military company, which turned London into a surveillance state in the aftermath of the bombings. ", "Watch Dogs: Legion", 60.0, new Guid("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"), new DateTimeOffset(new DateTime(2020, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("82349e02-c2c7-4781-8629-1501e943e99d"), "", "Experience Aloy’s legendary quest to unravel the mysteries of a future Earth ruled by Machines. Use devastating tactical attacks against your prey and explore a majestic open world in this award-winning action RPG! ", 99.989999999999995, new Guid("098280de-4136-47a9-93c5-0fe594638105"), new DateTimeOffset(new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("139320ef-df4e-473a-ada0-b9a548dcd68e"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("19e17050-6a29-4b8a-b863-87ee5ed041cb"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("1f552387-3728-413d-bf0f-835bfa6c2738"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("24514607-a2f8-4251-a011-97a9b3a62dfd"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("36697005-ce0a-40b2-ba06-99c33263016a"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("4013b6ad-0aef-4d13-9122-514cd3c6fb78"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("4182ee1c-864a-495d-b959-8987017d97b1"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("82349e02-c2c7-4781-8629-1501e943e99d"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("8bfe8fd0-3487-4502-a2a7-f593fbf6937a"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("8f1ff312-8202-4dcc-bf05-3cfe812bdca8"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("91e65ce8-3e78-46db-906c-41d918253467"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("a0fa0254-fe78-4eed-9c62-f514ea93550f"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("a2ab7c4f-9e87-4fe9-b118-cdbbc3dad657"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("a494d332-ab54-45bd-8ddf-722559d9705a"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("b490988a-c1cb-4a3e-a96a-3b0626c825a6"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("b678411e-f2b2-451e-a8f5-60e723bec245"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("b7a027dc-fa0a-444b-b903-2e3ad85a76bd"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("e0f4474b-b9d1-4b5b-8a01-470908300090"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("e27fff89-a17b-4d6a-b108-869703ecb3cd"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("e3c89efe-871c-4f4a-aecd-f2e620ffb39a"));

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "GameId",
                keyValue: new Guid("f1ac6f57-c10d-4700-91ce-cb5d9841a7bc"));

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Game");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Publisher",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Genre",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Game",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Name", "Price", "PublisherId", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("d3b9353b-81fb-4440-bfde-02477d749523"), "Resident Evil (Remake)", 19.989999999999998, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("84f75268-f146-4d74-ae4b-9f403ffc8b5d"), "Outlast 2", 59.990000000000002, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2017, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("6cdb208d-5c10-4b3c-bc7b-59a8969090ed"), "Outlast Whistleblower", 19.989999999999998, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2013, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("d88627ba-cbdf-442d-a292-2d9391fa6b01"), "Outlast", 39.990000000000002, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("dc436a80-ad4f-4629-ae05-3d3e3b703e9b"), "Darksiders 3", 39.990000000000002, new Guid("81d46aa2-d8a0-4dcb-82a7-9f32f05eddb3"), new DateTimeOffset(new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("efe0895e-5734-4bd1-b57f-4c286b209df4"), "Dragon Ball Z: Kakarot", 99.989999999999995, new Guid("af821292-a1d9-4dc4-9d27-405a4f85e48a"), new DateTimeOffset(new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("757bd454-56bb-4ea7-82a6-44b908865009"), "Kingdom Hearts: Melody of Memory", 19.989999999999998, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("5fad36b3-deb3-4c6a-8308-504a1d8caa28"), "Dragon Quest Tact", 59.990000000000002, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("761ee81a-aebd-48fc-a76d-14bd94d05203"), "Final Fantasy XVI", 39.990000000000002, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("16d88b83-d04f-4f1c-8f0f-da3caaf88f9c"), "Outlast Trials", 99.989999999999995, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("5a8f9dd9-eb68-4432-ab85-cea83ad8c081"), "Assassin's Creed Valhalla", 59.990000000000002, new Guid("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"), new DateTimeOffset(new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("bd162050-adb1-4aaf-92ac-4ed34365acd6"), "Halo: The Master Chief Collection", 49.990000000000002, new Guid("3cac1789-e877-48f7-8dc1-fd32dad85172"), new DateTimeOffset(new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("122abc80-dd11-482c-8a9e-84d64491c9f8"), "Need for Speed: Hot Pursuit Remastered", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("38e31c2b-2fb5-4674-87a6-5058044776e6"), "The Sims 4: Snowy Escape", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("842fa951-5862-47c4-8247-2fd58f9e925b"), "Mass Effect 2", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2011, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("05030f44-1cc1-4705-8425-dff570338af0"), "Sonic the Hedgehog", 4.9900000000000002, new Guid("3817acf1-4920-4c77-b2c9-d4000be9703a"), new DateTimeOffset(new DateTime(1999, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("bb697f12-3466-4b1d-a653-5fa47ce73b37"), "Resident Evil 4", 29.989999999999998, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2005, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("af4226d2-a907-4cc9-baaf-6ec82a6d6ba4"), "Resident Evil 3 (Remake)", 39.990000000000002, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("39b1c665-85fc-497b-ad67-6e564378d7b6"), "Resident Evil 2 (Remake)", 39.990000000000002, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("3b90fc64-88da-4a94-897a-14ce088cfc11"), "Watch Dogs: Legion", 60.0, new Guid("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"), new DateTimeOffset(new DateTime(2020, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("0821cc45-1c31-48a9-933e-4a01d9128d29"), "Horizon Zero Dawn™ Complete Edition", 99.989999999999995, new Guid("098280de-4136-47a9-93c5-0fe594638105"), new DateTimeOffset(new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });
        }
    }
}
