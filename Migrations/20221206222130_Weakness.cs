using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class Weakness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TypeWeakness",
                columns: table => new
                {
                    TypeWeaknessId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PokemonTypeId = table.Column<int>(nullable: false),
                    WeaknessId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeWeakness", x => x.TypeWeaknessId);
                    table.ForeignKey(
                        name: "FK_TypeWeakness_PokemonTypes_PokemonTypeId",
                        column: x => x.PokemonTypeId,
                        principalTable: "PokemonTypes",
                        principalColumn: "PokemonTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypeWeakness_PokemonTypes_WeaknessId",
                        column: x => x.WeaknessId,
                        principalTable: "PokemonTypes",
                        principalColumn: "PokemonTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 6, 17, 21, 29, 919, DateTimeKind.Local).AddTicks(7718));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 6, 17, 21, 29, 924, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2022, 12, 6, 17, 21, 29, 924, DateTimeKind.Local).AddTicks(4801));

            migrationBuilder.InsertData(
                table: "TypeWeakness",
                columns: new[] { "TypeWeaknessId", "PokemonTypeId", "WeaknessId" },
                values: new object[] { 1, 12, 10 });

            migrationBuilder.CreateIndex(
                name: "IX_TypeWeakness_PokemonTypeId",
                table: "TypeWeakness",
                column: "PokemonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeWeakness_WeaknessId",
                table: "TypeWeakness",
                column: "WeaknessId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TypeWeakness");

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
    }
}
