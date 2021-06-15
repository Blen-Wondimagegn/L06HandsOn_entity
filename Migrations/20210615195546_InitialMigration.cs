using Microsoft.EntityFrameworkCore.Migrations;

namespace L06HandsOn.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aliens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    BirthDate = table.Column<string>(type: "TEXT", nullable: true),
                    Arms = table.Column<int>(type: "INTEGER", nullable: false),
                    Heads = table.Column<int>(type: "INTEGER", nullable: false),
                    Legs = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aliens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aliens");
        }
    }
}
