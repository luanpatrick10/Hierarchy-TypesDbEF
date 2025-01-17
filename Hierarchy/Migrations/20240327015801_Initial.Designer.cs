﻿// <auto-generated />
using System;
using Hierarchy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Hierarchy.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20240327015801_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Hierarchy.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataDeInclusao")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.HasKey("Id");

                    b.ToTable("Pessoas");

                    b.HasDiscriminator<string>("Tipo").HasValue("Pessoa");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Hierarchy.PessoaFisica", b =>
                {
                    b.HasBaseType("Hierarchy.Pessoa");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("PJ");
                });

            modelBuilder.Entity("Hierarchy.PessoaJuridica", b =>
                {
                    b.HasBaseType("Hierarchy.Pessoa");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("PessoaJuridica");
                });
#pragma warning restore 612, 618
        }
    }
}
