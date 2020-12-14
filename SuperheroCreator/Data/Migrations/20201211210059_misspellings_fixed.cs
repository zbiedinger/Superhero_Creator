using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroCreator.Data.Migrations
{
    public partial class misspellings_fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlterRegos_Superheroes_SuperheroId",
                table: "AlterRegos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlterRegos",
                table: "AlterRegos");

            migrationBuilder.RenameTable(
                name: "AlterRegos",
                newName: "AlterEgos");

            migrationBuilder.RenameIndex(
                name: "IX_AlterRegos_SuperheroId",
                table: "AlterEgos",
                newName: "IX_AlterEgos_SuperheroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlterEgos",
                table: "AlterEgos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlterEgos_Superheroes_SuperheroId",
                table: "AlterEgos",
                column: "SuperheroId",
                principalTable: "Superheroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlterEgos_Superheroes_SuperheroId",
                table: "AlterEgos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AlterEgos",
                table: "AlterEgos");

            migrationBuilder.RenameTable(
                name: "AlterEgos",
                newName: "AlterRegos");

            migrationBuilder.RenameIndex(
                name: "IX_AlterEgos_SuperheroId",
                table: "AlterRegos",
                newName: "IX_AlterRegos_SuperheroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlterRegos",
                table: "AlterRegos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AlterRegos_Superheroes_SuperheroId",
                table: "AlterRegos",
                column: "SuperheroId",
                principalTable: "Superheroes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
