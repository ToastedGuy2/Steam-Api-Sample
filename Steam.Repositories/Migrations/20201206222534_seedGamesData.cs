using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Steam.Repositories.Migrations
{
    public partial class seedGamesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("ad2f4d1c-7a67-448c-a3e8-74a7cc7813a5"));

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Game",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Name", "Price", "PublisherId", "ReleaseDate" },
                values: new object[,]
                {
                    { new Guid("d3b9353b-81fb-4440-bfde-02477d749523"), "Resident Evil (Remake)", 19.989999999999998, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2002, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("0821cc45-1c31-48a9-933e-4a01d9128d29"), "Horizon Zero Dawn™ Complete Edition", 99.989999999999995, new Guid("098280de-4136-47a9-93c5-0fe594638105"), new DateTimeOffset(new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("16d88b83-d04f-4f1c-8f0f-da3caaf88f9c"), "Outlast Trials", 99.989999999999995, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2021, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("84f75268-f146-4d74-ae4b-9f403ffc8b5d"), "Outlast 2", 59.990000000000002, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2017, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("6cdb208d-5c10-4b3c-bc7b-59a8969090ed"), "Outlast Whistleblower", 19.989999999999998, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2013, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("d88627ba-cbdf-442d-a292-2d9391fa6b01"), "Outlast", 39.990000000000002, new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), new DateTimeOffset(new DateTime(2013, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("dc436a80-ad4f-4629-ae05-3d3e3b703e9b"), "Darksiders 3", 39.990000000000002, new Guid("81d46aa2-d8a0-4dcb-82a7-9f32f05eddb3"), new DateTimeOffset(new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("efe0895e-5734-4bd1-b57f-4c286b209df4"), "Dragon Ball Z: Kakarot", 99.989999999999995, new Guid("af821292-a1d9-4dc4-9d27-405a4f85e48a"), new DateTimeOffset(new DateTime(2020, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("757bd454-56bb-4ea7-82a6-44b908865009"), "Kingdom Hearts: Melody of Memory", 19.989999999999998, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("5fad36b3-deb3-4c6a-8308-504a1d8caa28"), "Dragon Quest Tact", 59.990000000000002, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("bd162050-adb1-4aaf-92ac-4ed34365acd6"), "Halo: The Master Chief Collection", 49.990000000000002, new Guid("3cac1789-e877-48f7-8dc1-fd32dad85172"), new DateTimeOffset(new DateTime(2019, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("122abc80-dd11-482c-8a9e-84d64491c9f8"), "Need for Speed: Hot Pursuit Remastered", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2020, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("38e31c2b-2fb5-4674-87a6-5058044776e6"), "The Sims 4: Snowy Escape", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("842fa951-5862-47c4-8247-2fd58f9e925b"), "Mass Effect 2", 9.9900000000000002, new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), new DateTimeOffset(new DateTime(2011, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("05030f44-1cc1-4705-8425-dff570338af0"), "Sonic the Hedgehog", 4.9900000000000002, new Guid("3817acf1-4920-4c77-b2c9-d4000be9703a"), new DateTimeOffset(new DateTime(1999, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("bb697f12-3466-4b1d-a653-5fa47ce73b37"), "Resident Evil 4", 29.989999999999998, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2005, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("af4226d2-a907-4cc9-baaf-6ec82a6d6ba4"), "Resident Evil 3 (Remake)", 39.990000000000002, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2020, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("39b1c665-85fc-497b-ad67-6e564378d7b6"), "Resident Evil 2 (Remake)", 39.990000000000002, new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), new DateTimeOffset(new DateTime(2019, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) },
                    { new Guid("761ee81a-aebd-48fc-a76d-14bd94d05203"), "Final Fantasy XVI", 39.990000000000002, new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), new DateTimeOffset(new DateTime(2020, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) }
                });

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("098280de-4136-47a9-93c5-0fe594638105"),
                column: "Name",
                value: "PlayStation Mobile, Inc.");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("3cac1789-e877-48f7-8dc1-fd32dad85172"),
                column: "Name",
                value: "Xbox Game Studios");

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { new Guid("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"), "Ubisoft" });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Name", "Price", "PublisherId", "ReleaseDate" },
                values: new object[] { new Guid("3b90fc64-88da-4a94-897a-14ce088cfc11"), "Watch Dogs: Legion", 60.0, new Guid("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"), new DateTimeOffset(new DateTime(2020, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "GameId", "Name", "Price", "PublisherId", "ReleaseDate" },
                values: new object[] { new Guid("5a8f9dd9-eb68-4432-ab85-cea83ad8c081"), "Assassin's Creed Valhalla", 59.990000000000002, new Guid("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"), new DateTimeOffset(new DateTime(2020, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -6, 0, 0, 0)) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("a4d1cd2f-7a67-448c-a3e8-74a7cc7813a5"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Game");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("098280de-4136-47a9-93c5-0fe594638105"),
                column: "Name",
                value: "Sony");

            migrationBuilder.UpdateData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("3cac1789-e877-48f7-8dc1-fd32dad85172"),
                column: "Name",
                value: "Microsoft");

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[] { new Guid("ad2f4d1c-7a67-448c-a3e8-74a7cc7813a5"), "Ubisoft" });
        }
    }
}
