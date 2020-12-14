using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperheroCreator.Data.Migrations
{
    public partial class changed_key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlterRegos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Job = table.Column<string>(nullable: true),
                    Home = table.Column<string>(nullable: true),
                    RelationshipStatus = table.Column<string>(nullable: true),
                    SuperheroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlterRegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AlterRegos_Superheroes_SuperheroId",
                        column: x => x.SuperheroId,
                        principalTable: "Superheroes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlterRegos_SuperheroId",
                table: "AlterRegos",
                column: "SuperheroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlterRegos");
        }
    }
}
