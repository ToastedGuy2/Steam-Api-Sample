using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Steam.Repositories.Migrations
{
    public partial class SeedPublisherData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "PublisherId", "Name" },
                values: new object[,]
                {
                    { new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"), "Capcom" },
                    { new Guid("3817acf1-4920-4c77-b2c9-d4000be9703a"), "Sega" },
                    { new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"), "Electronic Arts" },
                    { new Guid("3cac1789-e877-48f7-8dc1-fd32dad85172"), "Microsoft" },
                    { new Guid("ad2f4d1c-7a67-448c-a3e8-74a7cc7813a5"), "Ubisoft" },
                    { new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"), "Square Enix" },
                    { new Guid("af821292-a1d9-4dc4-9d27-405a4f85e48a"), "Bandai Namco Entertainment" },
                    { new Guid("81d46aa2-d8a0-4dcb-82a7-9f32f05eddb3"), "THQ Nordic" },
                    { new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"), "Red Barrel" },
                    { new Guid("098280de-4136-47a9-93c5-0fe594638105"), "Sony" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("098280de-4136-47a9-93c5-0fe594638105"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("3817acf1-4920-4c77-b2c9-d4000be9703a"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("3cac1789-e877-48f7-8dc1-fd32dad85172"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("589c2fd3-2a74-4f4e-90f7-400d39edcb38"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("81d46aa2-d8a0-4dcb-82a7-9f32f05eddb3"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("97f4b78d-5752-413f-9f2e-0bfa4947d490"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("9d30ed06-41be-4e27-b16c-34e65015dcc8"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("a2bc460c-ab39-4903-81df-367bbf5453eb"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("ad2f4d1c-7a67-448c-a3e8-74a7cc7813a5"));

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "PublisherId",
                keyValue: new Guid("af821292-a1d9-4dc4-9d27-405a4f85e48a"));
        }
    }
}
