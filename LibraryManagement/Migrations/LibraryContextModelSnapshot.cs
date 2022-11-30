﻿// <auto-generated />
using System;
using LibraryManagment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagement.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("LibraryManagment.Models.Emprunt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateDebut")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DateFin")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("OuvrageId")
                        .HasColumnType("int");

                    b.Property<bool>("Retourne")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("OuvrageId");

                    b.ToTable("Emprunts");
                });

            modelBuilder.Entity("LibraryManagment.Models.Ouvrage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Auteur")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Disponible")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Type");

                    b.ToTable("Ouvrages");

                    b.HasDiscriminator<string>("Type").HasValue("Ouvrage");
                });

            modelBuilder.Entity("LibraryManagment.Models.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Utilisateurs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Utilisateur");
                });

            modelBuilder.Entity("LibraryManagment.Models.CD", b =>
                {
                    b.HasBaseType("LibraryManagment.Models.Ouvrage");

                    b.HasDiscriminator().HasValue("CD");
                });

            modelBuilder.Entity("LibraryManagment.Models.Client", b =>
                {
                    b.HasBaseType("LibraryManagment.Models.Utilisateur");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.HasIndex("CIN")
                        .IsUnique();

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("LibraryManagment.Models.Livre", b =>
                {
                    b.HasBaseType("LibraryManagment.Models.Ouvrage");

                    b.Property<string>("Editeur")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasDiscriminator().HasValue("Livre");
                });

            modelBuilder.Entity("LibraryManagment.Models.Periodique", b =>
                {
                    b.HasBaseType("LibraryManagment.Models.Ouvrage");

                    b.Property<int>("Periodicite")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Periodique");
                });

            modelBuilder.Entity("LibraryManagment.Models.Responsable", b =>
                {
                    b.HasBaseType("LibraryManagment.Models.Utilisateur");

                    b.Property<bool>("Admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(127)
                        .HasColumnType("varchar(127)");

                    b.HasDiscriminator().HasValue("Responsable");
                });

            modelBuilder.Entity("LibraryManagment.Models.Emprunt", b =>
                {
                    b.HasOne("LibraryManagment.Models.Client", "Client")
                        .WithMany("Emprunts")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManagment.Models.Ouvrage", "Ouvrage")
                        .WithMany("Emprunts")
                        .HasForeignKey("OuvrageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Ouvrage");
                });

            modelBuilder.Entity("LibraryManagment.Models.Ouvrage", b =>
                {
                    b.Navigation("Emprunts");
                });

            modelBuilder.Entity("LibraryManagment.Models.Client", b =>
                {
                    b.Navigation("Emprunts");
                });
#pragma warning restore 612, 618
        }
    }
}
