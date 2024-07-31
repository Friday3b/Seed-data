using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hometask_crud.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authors1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authors1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "categories1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "books1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Page = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books1", x => x.Id);
                    table.ForeignKey(
                        name: "FK_books1_authors1_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "authors1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_books1_categories1_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "authors1",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Daniel", "Defoe" },
                    { 2, "Lewis", "Carroll" },
                    { 3, "Veda", "Vyas" }
                });

            migrationBuilder.InsertData(
                table: "categories1",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Non-Fiction" },
                    { 2, "Poems" },
                    { 3, "Western" }
                });

            migrationBuilder.InsertData(
                table: "books1",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Name", "Page" },
                values: new object[,]
                {
                    { 1, 1, 1, "Adventures of Robinson Crusoe", "100" },
                    { 2, 2, 2, "Alice in Wonderland", "150" },
                    { 3, 3, 3, "Bhagwat Gita", "300" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_books1_AuthorId",
                table: "books1",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_books1_CategoryId",
                table: "books1",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books1");

            migrationBuilder.DropTable(
                name: "authors1");

            migrationBuilder.DropTable(
                name: "categories1");
        }
    }
}
