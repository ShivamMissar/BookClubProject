using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookclub.Migrations
{
    /// <inheritdoc />
    public partial class orderedReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "bookName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bookName",
                table: "Reviews");
        }
    }
}
