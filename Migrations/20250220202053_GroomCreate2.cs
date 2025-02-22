using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCentral.Migrations
{
    /// <inheritdoc />
    public partial class GroomCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Supplies",
                table: "Grooming",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Supplies",
                table: "Grooming");
        }
    }
}
