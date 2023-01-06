using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookclub.Migrations
{
    /// <inheritdoc />
    public partial class changedDBName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_booksDB",
                table: "booksDB");

            migrationBuilder.RenameTable(
                name: "booksDB",
                newName: "Books");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "BooksID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "booksDB");

            migrationBuilder.AddPrimaryKey(
                name: "PK_booksDB",
                table: "booksDB",
                column: "BooksID");
        }
    }
}
