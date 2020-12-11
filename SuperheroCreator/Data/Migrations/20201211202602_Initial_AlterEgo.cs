using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroCreator.Data.Migrations
{
    public partial class Initial_AlterEgo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlterEgo",
                table: "Superheroes");

            migrationBuilder.AddColumn<string>(
                name: "AlterEgoFirstName",
                table: "Superheroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AlterEgoLastName",
                table: "Superheroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlterEgoFirstName",
                table: "Superheroes");

            migrationBuilder.DropColumn(
                name: "AlterEgoLastName",
                table: "Superheroes");

            migrationBuilder.AddColumn<string>(
                name: "AlterEgo",
                table: "Superheroes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
