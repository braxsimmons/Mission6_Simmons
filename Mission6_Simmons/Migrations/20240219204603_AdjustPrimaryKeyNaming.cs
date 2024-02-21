using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Simmons.Migrations
{
    /// <inheritdoc />
    public partial class AdjustPrimaryKeyNaming : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "movieID");

            migrationBuilder.AddColumn<int>(
                name: "categoryID",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "categoryID",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "movieID",
                table: "Movies",
                newName: "Id");
        }
    }
}
