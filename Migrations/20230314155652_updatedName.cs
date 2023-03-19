using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookclub.Migrations
{
    /// <inheritdoc />
    public partial class updatedName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "optionalName",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "optionalName",
                table: "Reviews");
        }
    }
}
