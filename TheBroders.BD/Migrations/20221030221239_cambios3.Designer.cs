﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheBroders.BD.DATA;

#nullable disable

namespace TheBroders.BD.Migrations
{
    [DbContext(typeof(BDtc))]
    [Migration("20221030221239_cambios3")]
    partial class cambios3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TheBroders.BD.DATA.Entidades.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TheBroders.BD.DATA.Entidades.Turno", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("Hora")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("fecha")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Turnos");
                });

            modelBuilder.Entity("TheBroders.BD.DATA.Entidades.Turno", b =>
                {
                    b.HasOne("TheBroders.BD.DATA.Entidades.Cliente", "Cliente")
                        .WithMany("turnos")
                        .HasForeignKey("ClienteID");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("TheBroders.BD.DATA.Entidades.Cliente", b =>
                {
                    b.Navigation("turnos");
                });
#pragma warning restore 612, 618
        }
    }
}
