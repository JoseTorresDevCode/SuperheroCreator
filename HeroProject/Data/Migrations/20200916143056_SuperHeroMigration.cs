using Microsoft.EntityFrameworkCore.Migrations;

namespace HeroProject.Data.Migrations
{
    public partial class SuperHeroMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heroes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    altEgoFirstName = table.Column<string>(nullable: true),
                    altEgoLastName = table.Column<string>(nullable: true),
                    primaryAbility = table.Column<string>(nullable: true),
                    secondaryAbility = table.Column<string>(nullable: true),
                    catchphrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heroes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Heroes");
        }
    }
}
