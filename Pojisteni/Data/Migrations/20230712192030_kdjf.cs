using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pojisteni.Data.Migrations
{
    public partial class kdjf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cislo",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Ulice",
                table: "User",
                newName: "UliceCislo");

            migrationBuilder.RenameColumn(
                name: "Nazev",
                table: "Insurance",
                newName: "Typ");

            migrationBuilder.AddColumn<DateTime>(
                name: "PlatnostDo",
                table: "Insurance",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Predmet",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlatnostDo",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "Predmet",
                table: "Insurance");

            migrationBuilder.RenameColumn(
                name: "UliceCislo",
                table: "User",
                newName: "Ulice");

            migrationBuilder.RenameColumn(
                name: "Typ",
                table: "Insurance",
                newName: "Nazev");

            migrationBuilder.AddColumn<int>(
                name: "Cislo",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
