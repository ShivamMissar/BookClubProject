using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookclub.Migrations
{
    /// <inheritdoc />
    public partial class createdDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "booksDB",
                columns: table => new
                {
                    BooksID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BooksDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    imageAltDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booksDB", x => x.BooksID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booksDB");
        }
    }
}
