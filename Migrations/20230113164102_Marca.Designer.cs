﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProiectBun.Data;

#nullable disable

namespace ProiectBun.Migrations
{
    [DbContext(typeof(ProiectBunContext))]
    [Migration("20230113164102_Marca")]
    partial class Marca
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProiectBun.Models.Marca", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("MarcaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Marca");
                });

            modelBuilder.Entity("ProiectBun.Models.Utilaj", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MarcaID")
                        .HasColumnType("int");

                    b.Property<string>("NumeUtilaj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Pret")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sofer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("MarcaID");

                    b.ToTable("Utilaj");
                });

            modelBuilder.Entity("ProiectBun.Models.Utilaj", b =>
                {
                    b.HasOne("ProiectBun.Models.Marca", "Marca")
                        .WithMany("Utilaje")
                        .HasForeignKey("MarcaID");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("ProiectBun.Models.Marca", b =>
                {
                    b.Navigation("Utilaje");
                });
#pragma warning restore 612, 618
        }
    }
}
