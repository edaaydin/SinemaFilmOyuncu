﻿// <auto-generated />
using System;
using BeyazPerde.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BeyazPerde.Migrations
{
    [DbContext(typeof(SinemaDbContext))]
    [Migration("20241025125732_One")]
    partial class One
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BeyazPerde.Models.Concrete.Film", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("FirstName");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("YayinlanmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("YonetmenID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("YonetmenID");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("BeyazPerde.Models.Concrete.Oyuncu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Oyuncus");
                });

            modelBuilder.Entity("BeyazPerde.Models.Concrete.OyuncuFilm", b =>
                {
                    b.Property<int>("OyuncuID")
                        .HasColumnType("int");

                    b.Property<int>("FilmID")
                        .HasColumnType("int");

                    b.HasKey("OyuncuID", "FilmID");

                    b.HasIndex("FilmID");

                    b.ToTable("OyuncuFilms");
                });

            modelBuilder.Entity("BeyazPerde.Models.Concrete.Yonetmen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Yonetmens");
                });

            modelBuilder.Entity("BeyazPerde.Models.Concrete.Film", b =>
                {
                    b.HasOne("BeyazPerde.Models.Concrete.Yonetmen", "Yonetmen")
                        .WithMany("YonetmeninFilmleri")
                        .HasForeignKey("YonetmenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Yonetmen");
                });

            modelBuilder.Entity("BeyazPerde.Models.Concrete.OyuncuFilm", b =>
                {
                    b.HasOne("BeyazPerde.Models.Concrete.Film", "Filmi")
                        .WithMany("Oyunculari")
                        .HasForeignKey("FilmID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeyazPerde.Models.Concrete.Oyuncu", "Oyuncusu")
                        .WithMany("Filmleri")
                        .HasForeignKey("OyuncuID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Filmi");

                    b.Navigation("Oyuncusu");
                });

            modelBuilder.Entity("BeyazPerde.Models.Concrete.Film", b =>
                {
                    b.Navigation("Oyunculari");
                });

            modelBuilder.Entity("BeyazPerde.Models.Concrete.Oyuncu", b =>
                {
                    b.Navigation("Filmleri");
                });

            modelBuilder.Entity("BeyazPerde.Models.Concrete.Yonetmen", b =>
                {
                    b.Navigation("YonetmeninFilmleri");
                });
#pragma warning restore 612, 618
        }
    }
}
