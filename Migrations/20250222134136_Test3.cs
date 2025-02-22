using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatCentral.Migrations
{
    /// <inheritdoc />
    public partial class Test3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Food",
                table: "Grooming");

            migrationBuilder.DropColumn(
                name: "Toys",
                table: "Grooming");

            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "Grooming",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToyID",
                table: "Grooming",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Grooming_FoodID",
                table: "Grooming",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Grooming_ToyID",
                table: "Grooming",
                column: "ToyID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grooming_Food_FoodID",
                table: "Grooming",
                column: "FoodID",
                principalTable: "Food",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Grooming_Toy_ToyID",
                table: "Grooming",
                column: "ToyID",
                principalTable: "Toy",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grooming_Food_FoodID",
                table: "Grooming");

            migrationBuilder.DropForeignKey(
                name: "FK_Grooming_Toy_ToyID",
                table: "Grooming");

            migrationBuilder.DropIndex(
                name: "IX_Grooming_FoodID",
                table: "Grooming");

            migrationBuilder.DropIndex(
                name: "IX_Grooming_ToyID",
                table: "Grooming");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "Grooming");

            migrationBuilder.DropColumn(
                name: "ToyID",
                table: "Grooming");

            migrationBuilder.AddColumn<string>(
                name: "Food",
                table: "Grooming",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Toys",
                table: "Grooming",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
