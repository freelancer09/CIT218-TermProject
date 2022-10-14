using Microsoft.EntityFrameworkCore.Migrations;

namespace TermProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PokemonTypes",
                columns: table => new
                {
                    PokemonTypeId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
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
                    PokemonTypeId1 = table.Column<string>(nullable: false),
                    PokemonType1PokemonTypeId = table.Column<string>(nullable: true),
                    PokemonTypeId2 = table.Column<string>(nullable: true),
                    PokemonType2PokemonTypeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.PokemonId);
                    table.ForeignKey(
                        name: "FK_Pokemons_PokemonTypes_PokemonType1PokemonTypeId",
                        column: x => x.PokemonType1PokemonTypeId,
                        principalTable: "PokemonTypes",
                        principalColumn: "PokemonTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pokemons_PokemonTypes_PokemonType2PokemonTypeId",
                        column: x => x.PokemonType2PokemonTypeId,
                        principalTable: "PokemonTypes",
                        principalColumn: "PokemonTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "PokemonTypes",
                columns: new[] { "PokemonTypeId", "Name" },
                values: new object[,]
                {
                    { "Gho", "Ghost" },
                    { "Dra", "Dragon" },
                    { "Ice", "Ice" },
                    { "Psy", "Psychic" },
                    { "Ele", "Electric" },
                    { "Gra", "Grass" },
                    { "Wat", "Water" },
                    { "Fir", "Fire" },
                    { "Ste", "Steel" },
                    { "Dar", "Dark" },
                    { "Fai", "Fairy" },
                    { "Roc", "Rock" },
                    { "Gro", "Ground" },
                    { "Poi", "Poison" },
                    { "Fly", "Flying" },
                    { "Fig", "Fighting" },
                    { "Nor", "Normal" },
                    { "Bug", "Bug" }
                });

            migrationBuilder.InsertData(
                table: "Pokemons",
                columns: new[] { "PokemonId", "Attack", "Defense", "Hp", "Name", "PokedexNumber", "PokemonType1PokemonTypeId", "PokemonType2PokemonTypeId", "PokemonTypeId1", "PokemonTypeId2", "SpAttack", "SpDefense", "Speed" },
                values: new object[,]
                {
                    { 3, 100, 123, 80, "Venusaur", 3, null, null, "Gra", "Poi", 122, 120, 80 },
                    { 2, 62, 63, 60, "Ivysaur", 2, null, null, "Gra", "Poi", 80, 80, 60 },
                    { 1, 49, 49, 45, "Bulbasaur", 1, null, null, "Gra", "Poi", 65, 65, 45 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonType1PokemonTypeId",
                table: "Pokemons",
                column: "PokemonType1PokemonTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PokemonType2PokemonTypeId",
                table: "Pokemons",
                column: "PokemonType2PokemonTypeId");
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
