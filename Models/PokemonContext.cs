using Microsoft.EntityFrameworkCore;

namespace TermProject.Models
{
    public class PokemonContext : DbContext
    {
        public PokemonContext(DbContextOptions<PokemonContext> options) : base(options) { }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<TypeWeakness> TypeWeakness { get; set; }
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
                    Attack = 82,
                    Defense = 83,
                    SpAttack = 100,
                    SpDefense = 100,
                    Speed = 80,
                    PokemonType1Id = 12,
                    PokemonType2Id = 4
                },
                new Pokemon
                {
                    PokemonId = 4,
                    PokedexNumber = 4,
                    Name = "Charmander",
                    Hp = 39,
                    Attack = 52,
                    Defense = 43,
                    SpAttack = 60,
                    SpDefense = 50,
                    Speed = 65,
                    PokemonType1Id = 10
                },
                new Pokemon
                {
                    PokemonId = 5,
                    PokedexNumber = 5,
                    Name = "Charmeleon",
                    Hp = 58,
                    Attack = 64,
                    Defense = 58,
                    SpAttack = 80,
                    SpDefense = 65,
                    Speed = 80,
                    PokemonType1Id = 10
                },
                new Pokemon
                {
                    PokemonId = 6,
                    PokedexNumber = 6,
                    Name = "Charizard",
                    Hp = 78,
                    Attack = 84,
                    Defense = 78,
                    SpAttack = 109,
                    SpDefense = 85,
                    Speed = 100,
                    PokemonType1Id = 10,
                    PokemonType2Id = 3
                },
                new Pokemon
                {
                    PokemonId = 7,
                    PokedexNumber = 7,
                    Name = "Squirtle",
                    Hp = 44,
                    Attack = 48,
                    Defense = 65,
                    SpAttack = 50,
                    SpDefense = 64,
                    Speed = 43,
                    PokemonType1Id = 11
                },
                new Pokemon
                {
                    PokemonId = 8,
                    PokedexNumber = 8,
                    Name = "Wartortle",
                    Hp = 59,
                    Attack = 63,
                    Defense = 80,
                    SpAttack = 65,
                    SpDefense = 80,
                    Speed = 58,
                    PokemonType1Id = 11
                },
                new Pokemon
                {
                    PokemonId = 9,
                    PokedexNumber = 9,
                    Name = "Blastoise",
                    Hp = 79,
                    Attack = 83,
                    Defense = 100,
                    SpAttack = 85,
                    SpDefense = 105,
                    Speed = 78,
                    PokemonType1Id = 11
                },
                new Pokemon
                {
                    PokemonId = 10,
                    PokedexNumber = 10,
                    Name = "Caterpie",
                    Hp = 45,
                    Attack = 30,
                    Defense = 35,
                    SpAttack = 20,
                    SpDefense = 20,
                    Speed = 45,
                    PokemonType1Id = 7
                },
                new Pokemon
                {
                    PokemonId = 11,
                    PokedexNumber = 11,
                    Name = "Metapod",
                    Hp = 50,
                    Attack = 20,
                    Defense = 55,
                    SpAttack = 25,
                    SpDefense = 25,
                    Speed = 30,
                    PokemonType1Id = 7
                },
                new Pokemon
                {
                    PokemonId = 12,
                    PokedexNumber = 12,
                    Name = "Butterfree",
                    Hp = 60,
                    Attack = 45,
                    Defense = 50,
                    SpAttack = 90,
                    SpDefense = 80,
                    Speed = 70,
                    PokemonType1Id = 7,
                    PokemonType2Id = 3
                }

            );

            modelBuilder.Entity<PokemonType>().HasMany(t => t.TypeWeakness).WithOne(w => w.PokemonType).HasForeignKey(w => w.PokemonTypeId);

            modelBuilder.Entity<PokemonType>().HasMany(t => t.Weaknesses).WithOne(w => w.Weakness).HasForeignKey(w => w.WeaknessId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TypeWeakness>().HasData(
                new TypeWeakness
                {
                    TypeWeaknessId = 1,
                    PokemonTypeId = 1,
                    WeaknessId = 2
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 2,
                    PokemonTypeId = 10,
                    WeaknessId = 11
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 3,
                    PokemonTypeId = 10,
                    WeaknessId = 5
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 4,
                    PokemonTypeId = 10,
                    WeaknessId = 6
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 5,
                    PokemonTypeId = 11,
                    WeaknessId = 13
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 6,
                    PokemonTypeId = 11,
                    WeaknessId = 12
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 7,
                    PokemonTypeId = 13,
                    WeaknessId = 5
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 8,
                    PokemonTypeId = 12,
                    WeaknessId = 10
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 9,
                    PokemonTypeId = 12,
                    WeaknessId = 15
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 10,
                    PokemonTypeId = 12,
                    WeaknessId = 4
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 11,
                    PokemonTypeId = 12,
                    WeaknessId = 3
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 12,
                    PokemonTypeId = 12,
                    WeaknessId = 7
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 13,
                    PokemonTypeId = 15,
                    WeaknessId = 10
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 14,
                    PokemonTypeId = 15,
                    WeaknessId = 2
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 15,
                    PokemonTypeId = 15,
                    WeaknessId = 6
                },
                new TypeWeakness
                {
                    TypeWeaknessId = 16,
                    PokemonTypeId = 15,
                    WeaknessId = 9
                }
            );
        }
    }
}