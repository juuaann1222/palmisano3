﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using PalmisanoPromocion.Models;

namespace PalmisanoPromicion.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20201116004017_Inical")]
    partial class Inical
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("PalmisanoPromicion.Models.Generos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("PalmisanoPromicion.Models.Peliculas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GeneroId")
                        .HasColumnType("int");

                    b.Property<int?>("GenerosId")
                        .HasColumnType("int");

                    b.Property<string>("Resumen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titulo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trailer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenerosId");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("PalmisanoPromicion.Models.PeliculasActores", b =>
                {
                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("PersonaId")
                        .HasColumnType("int");

                    b.Property<int?>("PeliculasId")
                        .HasColumnType("int");

                    b.Property<int?>("PersonasId")
                        .HasColumnType("int");

                    b.HasKey("PeliculaId", "PersonaId");

                    b.HasIndex("PeliculasId");

                    b.HasIndex("PersonasId");

                    b.ToTable("peliculasActores");
                });

            modelBuilder.Entity("PalmisanoPromicion.Models.Personas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Biografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Foto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("PalmisanoPromicion.Models.Peliculas", b =>
                {
                    b.HasOne("TpPeliculas.Models.Generos", "Generos")
                        .WithMany()
                        .HasForeignKey("GenerosId");

                    b.Navigation("Generos");
                });

            modelBuilder.Entity("PalmisanoPromicion.Models.PeliculasActores", b =>
                {
                    b.HasOne("PalmisanoPromicion.Models.Peliculas", "Peliculas")
                        .WithMany()
                        .HasForeignKey("PeliculasId");

                    b.HasOne("PalmisanoPromicion.Models.Personas", "Personas")
                        .WithMany()
                        .HasForeignKey("PersonasId");

                    b.Navigation("Peliculas");

                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
