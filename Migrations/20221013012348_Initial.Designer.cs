﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Models;

namespace TermProject.Migrations
{
    [DbContext(typeof(PokemonContext))]
    [Migration("20221013012348_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TermProject.Models.Pokemon", b =>
                {
                    b.Property<int>("PokemonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Attack")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Defense")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Hp")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PokedexNumber")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("PokemonType1PokemonTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PokemonType2PokemonTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PokemonTypeId1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PokemonTypeId2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SpAttack")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("SpDefense")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("Speed")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("PokemonId");

                    b.HasIndex("PokemonType1PokemonTypeId");

                    b.HasIndex("PokemonType2PokemonTypeId");

                    b.ToTable("Pokemons");

                    b.HasData(
                        new
                        {
                            PokemonId = 1,
                            Attack = 49,
                            Defense = 49,
                            Hp = 45,
                            Name = "Bulbasaur",
                            PokedexNumber = 1,
                            PokemonTypeId1 = "Gra",
                            PokemonTypeId2 = "Poi",
                            SpAttack = 65,
                            SpDefense = 65,
                            Speed = 45
                        },
                        new
                        {
                            PokemonId = 2,
                            Attack = 62,
                            Defense = 63,
                            Hp = 60,
                            Name = "Ivysaur",
                            PokedexNumber = 2,
                            PokemonTypeId1 = "Gra",
                            PokemonTypeId2 = "Poi",
                            SpAttack = 80,
                            SpDefense = 80,
                            Speed = 60
                        },
                        new
                        {
                            PokemonId = 3,
                            Attack = 100,
                            Defense = 123,
                            Hp = 80,
                            Name = "Venusaur",
                            PokedexNumber = 3,
                            PokemonTypeId1 = "Gra",
                            PokemonTypeId2 = "Poi",
                            SpAttack = 122,
                            SpDefense = 120,
                            Speed = 80
                        });
                });

            modelBuilder.Entity("TermProject.Models.PokemonType", b =>
                {
                    b.Property<string>("PokemonTypeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PokemonTypeId");

                    b.ToTable("PokemonTypes");

                    b.HasData(
                        new
                        {
                            PokemonTypeId = "Nor",
                            Name = "Normal"
                        },
                        new
                        {
                            PokemonTypeId = "Fig",
                            Name = "Fighting"
                        },
                        new
                        {
                            PokemonTypeId = "Fly",
                            Name = "Flying"
                        },
                        new
                        {
                            PokemonTypeId = "Poi",
                            Name = "Poison"
                        },
                        new
                        {
                            PokemonTypeId = "Gro",
                            Name = "Ground"
                        },
                        new
                        {
                            PokemonTypeId = "Roc",
                            Name = "Rock"
                        },
                        new
                        {
                            PokemonTypeId = "Bug",
                            Name = "Bug"
                        },
                        new
                        {
                            PokemonTypeId = "Gho",
                            Name = "Ghost"
                        },
                        new
                        {
                            PokemonTypeId = "Ste",
                            Name = "Steel"
                        },
                        new
                        {
                            PokemonTypeId = "Fir",
                            Name = "Fire"
                        },
                        new
                        {
                            PokemonTypeId = "Wat",
                            Name = "Water"
                        },
                        new
                        {
                            PokemonTypeId = "Gra",
                            Name = "Grass"
                        },
                        new
                        {
                            PokemonTypeId = "Ele",
                            Name = "Electric"
                        },
                        new
                        {
                            PokemonTypeId = "Psy",
                            Name = "Psychic"
                        },
                        new
                        {
                            PokemonTypeId = "Ice",
                            Name = "Ice"
                        },
                        new
                        {
                            PokemonTypeId = "Dra",
                            Name = "Dragon"
                        },
                        new
                        {
                            PokemonTypeId = "Dar",
                            Name = "Dark"
                        },
                        new
                        {
                            PokemonTypeId = "Fai",
                            Name = "Fairy"
                        });
                });

            modelBuilder.Entity("TermProject.Models.Pokemon", b =>
                {
                    b.HasOne("TermProject.Models.PokemonType", "PokemonType1")
                        .WithMany()
                        .HasForeignKey("PokemonType1PokemonTypeId");

                    b.HasOne("TermProject.Models.PokemonType", "PokemonType2")
                        .WithMany()
                        .HasForeignKey("PokemonType2PokemonTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
