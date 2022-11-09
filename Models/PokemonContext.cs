using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PokemonType>().HasData(
                new PokemonType { PokemonTypeId = 1, Name = "Normal" },
                new PokemonType { PokemonTypeId = 2, Name = "Fighting" },
                new PokemonType { PokemonTypeId = 3, Name = "Flying" },
                new PokemonType { PokemonTypeId = 4, Name = "Poison" },
                new PokemonType { PokemonTypeId = 5, Name = "Ground" },
                new PokemonType { PokemonTypeId = 6, Name = "Rock" },
                new PokemonType { PokemonTypeId = 7, Name = "Bug" },
                new PokemonType { PokemonTypeId = 8, Name = "Ghost" },
                new PokemonType { PokemonTypeId = 9, Name = "Steel" },
                new PokemonType { PokemonTypeId = 10, Name = "Fire" },
                new PokemonType { PokemonTypeId = 11, Name = "Water" },
                new PokemonType { PokemonTypeId = 12, Name = "Grass" },
                new PokemonType { PokemonTypeId = 13, Name = "Electric" },
                new PokemonType { PokemonTypeId = 14, Name = "Psychic" },
                new PokemonType { PokemonTypeId = 15, Name = "Ice" },
                new PokemonType { PokemonTypeId = 16, Name = "Dragon" },
                new PokemonType { PokemonTypeId = 17, Name = "Dark" },
                new PokemonType { PokemonTypeId = 18, Name = "Fairy" }
                );

            modelBuilder.Entity<Pokemon>().HasData(
                new Pokemon
                {
                    PokemonId = 1,
                    PokedexNumber = 1,
                    Name = "Bulbasaur",
                    Hp = 45,
                    Attack = 49,
                    Defense = 49,
                    SpAttack = 65,
                    SpDefense = 65,
                    Speed = 45,
                    PokemonType1Id = 12,
                    PokemonType2Id = 4
                },
                new Pokemon
                {
                    PokemonId = 2,
                    PokedexNumber = 2,
                    Name = "Ivysaur",
                    Hp = 60,
                    Attack = 62,
                    Defense = 63,
                    SpAttack = 80,
                    SpDefense = 80,
                    Speed = 60,
                    PokemonType1Id = 12,
                    PokemonType2Id = 4
                },
                new Pokemon
                {
                    PokemonId = 3,
                    PokedexNumber = 3,
                    Name = "Venusaur",
                    Hp = 80,
                    Attack = 100,
                    Defense = 123,
                    SpAttack = 122,
                    SpDefense = 120,
                    Speed = 80,
                    PokemonType1Id = 12,
                    PokemonType2Id = 4
                }
            );
        }
    }
}