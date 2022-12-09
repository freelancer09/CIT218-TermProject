using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class SeedUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 17, 41, 2, 922, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 3,
                columns: new[] { "Attack", "DateAdded", "Defense", "SpAttack", "SpDefense" },
                values: new object[] { 82, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5876), 83, 100, 100 });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "PokemonId", "Attack", "DateAdded", "Defense", "Hp", "Name", "Pokedex Number", "PokemonType1Id", "PokemonType2Id", "SpAttack", "SpDefense", "Speed" },
                values: new object[,]
                {
                    { 12, 45, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5924), 50, 60, "Butterfree", 12, 7, 3, 90, 80, 70 },
                    { 11, 20, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5919), 55, 50, "Metapod", 11, 7, null, 25, 25, 30 },
                    { 10, 30, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5913), 35, 45, "Caterpie", 10, 7, null, 20, 20, 45 },
                    { 4, 52, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5885), 43, 39, "Charmander", 4, 10, null, 60, 50, 65 },
                    { 8, 63, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5904), 80, 59, "Wartortle", 8, 11, null, 65, 80, 58 },
                    { 7, 48, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5899), 65, 44, "Squirtle", 7, 11, null, 50, 64, 43 },
                    { 5, 64, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5890), 58, 58, "Charmeleon", 5, 10, null, 80, 65, 80 },
                    { 6, 84, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5894), 78, 78, "Charizard", 6, 10, 3, 109, 85, 100 },
                    { 9, 83, new DateTime(2022, 12, 8, 17, 41, 2, 926, DateTimeKind.Local).AddTicks(5909), 100, 79, "Blastoise", 9, 11, null, 85, 105, 78 }
                });

            migrationBuilder.UpdateData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 1,
                columns: new[] { "PokemonTypeId", "WeaknessId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "TypeWeakness",
                columns: new[] { "TypeWeaknessId", "PokemonTypeId", "WeaknessId" },
                values: new object[,]
                {
                    { 16, 15, 9 },
                    { 15, 15, 6 },
                    { 14, 15, 2 },
                    { 13, 15, 10 },
                    { 12, 12, 7 },
                    { 10, 12, 4 },
                    { 9, 12, 15 },
                    { 8, 12, 10 },
                    { 7, 13, 5 },
                    { 5, 11, 13 },
                    { 4, 10, 6 },
                    { 3, 10, 5 },
                    { 2, 10, 11 },
                    { 11, 12, 3 },
                    { 6, 11, 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 16);

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
                columns: new[] { "Attack", "DateAdded", "Defense", "SpAttack", "SpDefense" },
                values: new object[] { 100, new DateTime(2022, 12, 6, 17, 21, 29, 924, DateTimeKind.Local).AddTicks(4801), 123, 122, 120 });

            migrationBuilder.UpdateData(
                table: "TypeWeakness",
                keyColumn: "TypeWeaknessId",
                keyValue: 1,
                columns: new[] { "PokemonTypeId", "WeaknessId" },
                values: new object[] { 12, 10 });
        }
    }
}
