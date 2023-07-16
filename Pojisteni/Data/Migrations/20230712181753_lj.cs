using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pojisteni.Data.Migrations
{
    public partial class lj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prijmeni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cislo = table.Column<int>(type: "int", nullable: false),
                    Obec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PSC = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Insurance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazev = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Castka = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurance", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Insurance_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_UserId",
                table: "Insurance",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurance");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
