using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogPlatform.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "private" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "public" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "advertising" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "Author", "Body", "CategoryId", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 1, "Kevin Tousey", "Hello World!", 1, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Getting Started" },
                    { 2, "Emeril Lagasse", "Love me some frog legs...", 1, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eating Dinner" },
                    { 5, "Anonymous", "Meet me tomorrow at the Burger King on Front Street.", 1, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Don't Tell" },
                    { 6, "Marty McFly", "There's a party at my house, bring a friend!", 2, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tell Everybody!" },
                    { 3, "The MVC Team", "Call us for a free estimate on your MVC project...", 3, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "100% Free" },
                    { 4, "The C# Network", "Are you having problems getting your project to compile, call us!", 3, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call Now" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
