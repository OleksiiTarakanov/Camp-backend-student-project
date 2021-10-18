using Microsoft.EntityFrameworkCore.Migrations;

namespace CampProj.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TablePlaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Halfday = table.Column<bool>(type: "bit", nullable: false),
                    Fullday = table.Column<bool>(type: "bit", nullable: false),
                    Booked = table.Column<bool>(type: "bit", nullable: false),
                    BookerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TablePlaces", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TablePlaces");
        }
    }
}
