using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    PokemonTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTypes", x => x.PokemonTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    PokemonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    PokedexNumber = table.Column<int>(nullable: false),
                    Hp = table.Column<int>(nullable: false),
                    Attack = table.Column<int>(nullable: false),
                    Defense = table.Column<int>(nullable: false),
                    SpAttack = table.Column<int>(nullable: false),
                    SpDefense = table.Column<int>(nullable: false),
                    Speed = table.Column<int>(nullable: false),
                    PokemonType1Id = table.Column<int>(nullable: true),
                    PokemonType2Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_Pokemons_PokemonTypes_PokemonType1Id",
                        column: x => x.PokemonType1Id,
                        principalTable: "PokemonTypes",
                        principalColumn: "PokemonTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemons_PokemonTypes_PokemonType2Id",
                        column: x => x.PokemonType2Id,
                        principalTable: "PokemonTypes",
                        principalColumn: "PokemonTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonTypeId", "Name" },
                values: new object[,]
                {
                    { 1, "Normal" },
                    { 16, "Dragon" },
                    { 15, "Ice" },
                    { 14, "Psychic" },
                    { 13, "Electric" },
                    { 12, "Grass" },
                    { 11, "Water" },
                    { 10, "Fire" },
                    { 9, "Steel" },
                    { 8, "Ghost" },
                    { 7, "Bug" },
                    { 6, "Rock" },
                    { 5, "Ground" },
                    { 4, "Poison" },
                    { 3, "Flying" },
                    { 2, "Fighting" },
                    { 17, "Dark" },
                    { 18, "Fairy" }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "PokemonId", "Attack", "Defense", "Hp", "Name", "PokedexNumber", "PokemonType1Id", "PokemonType2Id", "SpAttack", "SpDefense", "Speed" },
                values: new object[] { 1, 49, 49, 45, "Bulbasaur", 1, 12, 4, 65, 65, 45 });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "PokemonId", "Attack", "Defense", "Hp", "Name", "PokedexNumber", "PokemonType1Id", "PokemonType2Id", "SpAttack", "SpDefense", "Speed" },
                values: new object[] { 2, 62, 63, 60, "Ivysaur", 2, 12, 4, 80, 80, 60 });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "PokemonId", "Attack", "Defense", "Hp", "Name", "PokedexNumber", "PokemonType1Id", "PokemonType2Id", "SpAttack", "SpDefense", "Speed" },
                values: new object[] { 3, 100, 123, 80, "Venusaur", 3, 12, 4, 122, 120, 80 });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonType1Id",
                table: "Pokemons",
                column: "PokemonType1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonType2Id",
                table: "Pokemons",
                column: "PokemonType2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "PokemonTypes");
        }
    }
}
