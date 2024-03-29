﻿// <auto-generated />
using System;
using Lesson_11.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lesson_11.Migrations
{
    [DbContext(typeof(VyukaContex))]
    [Migration("20230419151901_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lesson_11.EFCore.Hodnoceni", b =>
                {
                    b.Property<Guid>("HodnoceniId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DatumHodnoceni")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("HodnoceniStudenta")
                        .HasColumnType("int");

                    b.Property<int>("IdStudenta")
                        .HasColumnType("int");

                    b.Property<string>("ZkratkaPredmetu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HodnoceniId");

                    b.ToTable("Hodnocenis");
                });

            modelBuilder.Entity("Lesson_11.EFCore.Predmet", b =>
                {
                    b.Property<Guid>("PredmetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nazev")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Zkratka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PredmetId");

                    b.ToTable("Predmets");
                });

            modelBuilder.Entity("Lesson_11.EFCore.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("DatumNarozeni")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("IdStudenta")
                        .HasColumnType("int");

                    b.Property<string>("Jmeno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prijmeni")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Lesson_11.EFCore.ZapsanePredmety", b =>
                {
                    b.Property<Guid>("ZapsanePredmetyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IdStudenta")
                        .HasColumnType("int");

                    b.Property<string>("ZkratkaPredmetu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZapsanePredmetyId");

                    b.ToTable("ZapsanePredmets");
                });
#pragma warning restore 612, 618
        }
    }
}
