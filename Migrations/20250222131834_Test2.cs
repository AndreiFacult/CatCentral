using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCentral.Migrations
{
    /// <inheritdoc />
    public partial class Test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Grooming");

            migrationBuilder.AddColumn<int>(
                name: "GallerysID",
                table: "Grooming",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grooming_GallerysID",
                table: "Grooming",
                column: "GallerysID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grooming_Gallerys_GallerysID",
                table: "Grooming",
                column: "GallerysID",
                principalTable: "Gallerys",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grooming_Gallerys_GallerysID",
                table: "Grooming");

            migrationBuilder.DropIndex(
                name: "IX_Grooming_GallerysID",
                table: "Grooming");

            migrationBuilder.DropColumn(
                name: "GallerysID",
                table: "Grooming");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Grooming",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
