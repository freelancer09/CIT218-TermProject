using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class Fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_PokemonType1PokemonTypeId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_PokemonType2PokemonTypeId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_PokemonType1PokemonTypeId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_PokemonType2PokemonTypeId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonType1PokemonTypeId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonType2PokemonTypeId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonTypeId1",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonTypeId2",
                table: "Pokemons");

            migrationBuilder.AddColumn<string>(
                name: "PokemonType1Id",
                table: "Pokemons",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PokemonType2Id",
                table: "Pokemons",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 1,
                columns: new[] { "PokemonType1Id", "PokemonType2Id" },
                values: new object[] { "Gra", "Poi" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 2,
                columns: new[] { "PokemonType1Id", "PokemonType2Id" },
                values: new object[] { "Gra", "Poi" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 3,
                columns: new[] { "PokemonType1Id", "PokemonType2Id" },
                values: new object[] { "Gra", "Poi" });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonType1Id",
                table: "Pokemons",
                column: "PokemonType1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonType2Id",
                table: "Pokemons",
                column: "PokemonType2Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_PokemonType1Id",
                table: "Pokemons",
                column: "PokemonType1Id",
                principalTable: "PokemonTypes",
                principalColumn: "PokemonTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_PokemonType2Id",
                table: "Pokemons",
                column: "PokemonType2Id",
                principalTable: "PokemonTypes",
                principalColumn: "PokemonTypeId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_PokemonType1Id",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_PokemonTypes_PokemonType2Id",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_PokemonType1Id",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_PokemonType2Id",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonType1Id",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "PokemonType2Id",
                table: "Pokemons");

            migrationBuilder.AddColumn<string>(
                name: "PokemonType1PokemonTypeId",
                table: "Pokemons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PokemonType2PokemonTypeId",
                table: "Pokemons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PokemonTypeId1",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PokemonTypeId2",
                table: "Pokemons",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 1,
                columns: new[] { "PokemonTypeId1", "PokemonTypeId2" },
                values: new object[] { "Gra", "Poi" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 2,
                columns: new[] { "PokemonTypeId1", "PokemonTypeId2" },
                values: new object[] { "Gra", "Poi" });

            migrationBuilder.UpdateData(
                table: "Pokemons",
                keyColumn: "PokemonId",
                keyValue: 3,
                columns: new[] { "PokemonTypeId1", "PokemonTypeId2" },
                values: new object[] { "Gra", "Poi" });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonType1PokemonTypeId",
                table: "Pokemons",
                column: "PokemonType1PokemonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonType2PokemonTypeId",
                table: "Pokemons",
                column: "PokemonType2PokemonTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_PokemonType1PokemonTypeId",
                table: "Pokemons",
                column: "PokemonType1PokemonTypeId",
                principalTable: "PokemonTypes",
                principalColumn: "PokemonTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_PokemonTypes_PokemonType2PokemonTypeId",
                table: "Pokemons",
                column: "PokemonType2PokemonTypeId",
                principalTable: "PokemonTypes",
                principalColumn: "PokemonTypeId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
