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
                new PokemonType { PokemonTypeId = "Nor", Name = "Normal" },
                new PokemonType { PokemonTypeId = "Fig", Name = "Fighting" },
                new PokemonType { PokemonTypeId = "Fly", Name = "Flying" },
                new PokemonType { PokemonTypeId = "Poi", Name = "Poison" },
                new PokemonType { PokemonTypeId = "Gro", Name = "Ground" },
                new PokemonType { PokemonTypeId = "Roc", Name = "Rock" },
                new PokemonType { PokemonTypeId = "Bug", Name = "Bug" },
                new PokemonType { PokemonTypeId = "Gho", Name = "Ghost" },
                new PokemonType { PokemonTypeId = "Ste", Name = "Steel" },
                new PokemonType { PokemonTypeId = "Fir", Name = "Fire" },
                new PokemonType { PokemonTypeId = "Wat", Name = "Water" },
                new PokemonType { PokemonTypeId = "Gra", Name = "Grass" },
                new PokemonType { PokemonTypeId = "Ele", Name = "Electric" },
                new PokemonType { PokemonTypeId = "Psy", Name = "Psychic" },
                new PokemonType { PokemonTypeId = "Ice", Name = "Ice" },
                new PokemonType { PokemonTypeId = "Dra", Name = "Dragon" },
                new PokemonType { PokemonTypeId = "Dar", Name = "Dark" },
                new PokemonType { PokemonTypeId = "Fai", Name = "Fairy" }
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
                    PokemonType1Id = "Gra",
                    PokemonType2Id = "Poi"
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
                    PokemonType1Id = "Gra",
                    PokemonType2Id = "Poi"
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
                    PokemonType1Id = "Gra",
                    PokemonType2Id = "Poi"
                }
            );
        }
    }
}