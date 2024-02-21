using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6_Simmons.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Movies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
