﻿// <auto-generated />
using System;
using App.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace App.Migrations
{
    [DbContext(typeof(ClasesDatabaseContext))]
    [Migration("20240630234805_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("App.Models.Clase", b =>
                {
                    b.Property<int>("idClase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idClase"), 1L, 1);

                    b.Property<int?>("cursoidCurso")
                        .HasColumnType("int");

                    b.Property<int>("idCurso")
                        .HasColumnType("int");

                    b.Property<string>("linkVideo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombreClase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numeroClase")
                        .HasColumnType("int");

                    b.HasKey("idClase");

                    b.HasIndex("cursoidCurso");

                    b.ToTable("Clase");
                });

            modelBuilder.Entity("App.Models.Curso", b =>
                {
                    b.Property<int>("idCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idCurso"), 1L, 1);

                    b.Property<string>("nombreCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idCurso");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("App.Models.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"), 1L, 1);

                    b.Property<int>("edadUsuario")
                        .HasColumnType("int");

                    b.Property<string>("emailUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idCurso")
                        .HasColumnType("int");

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.HasIndex("idCurso");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("App.Models.Clase", b =>
                {
                    b.HasOne("App.Models.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoidCurso");

                    b.Navigation("curso");
                });

            modelBuilder.Entity("App.Models.Usuario", b =>
                {
                    b.HasOne("App.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("idCurso")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });
#pragma warning restore 612, 618
        }
    }
}
