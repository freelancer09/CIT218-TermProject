using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class Chapter11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PokedexNumber",
                table: "Pokemons",
                newName: "Pokedex Number");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PokemonTypes",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pokemons",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Pokemons",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 11, 13, 18, 39, 40, 667, DateTimeKind.Local).AddTicks(6802));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 11, 13, 18, 39, 40, 671, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 11, 13, 18, 39, 40, 671, DateTimeKind.Local).AddTicks(4129));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "Pokedex Number",
                table: "Pokemons",
                newName: "PokedexNumber");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PokemonTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);
        }
    }
}
